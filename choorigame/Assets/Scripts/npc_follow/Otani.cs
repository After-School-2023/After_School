using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Otani : MonoBehaviour
{
    public NavMeshAgent otani;
    public Transform player;
    public Animator animator;

    public float wanderRadius = 20f;
    public float wanderTimer = 5f;
    public float stopDistance = 2f;

    private Transform target;
    private float timer;
    private bool isPaused = false;
    private int interaction_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        otani = GetComponent<NavMeshAgent>();
        if (otani == null)
        {
            Debug.LogError("NavMeshAgent component is not attached!");
        }
        else
        {
            otani.enabled = true;
        }

        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component is not attached!");
        }

        if (player == null)
        {
            Debug.LogError("Player transform is not assigned!");
        }

        timer = wanderTimer;

        SetNewRandomDestination();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)){

            if(interaction_count == 0){
                animator.SetTrigger("Interaction");
            }

            if(interaction_count <= 2){
                isPaused = true;
            } else{
                isPaused = false;
                interaction_count = 0;
                animator.SetTrigger("Interaction");
            }

            interaction_count++;

            if(isPaused){
                otani.isStopped = true;
            }else{
                otani.isStopped = false;
            }
        }

        if (!isPaused)
        {
            timer += Time.deltaTime;

            if (timer >= wanderTimer)
            {
                SetNewRandomDestination();
                timer = 0;
            }
        }
    }

    void SetNewRandomDestination()
    {
        Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
        otani.SetDestination(newPos);
    }

    // 랜덤한 위치 생성
    Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
