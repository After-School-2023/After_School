
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GeikoFollow : MonoBehaviour
{
    public NavMeshAgent geiko;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        geiko = GetComponent<NavMeshAgent>();
        if (geiko == null)
        {
            Debug.LogError("NavMeshAgent component is not attached!");
        }

        if (player == null)
        {
            Debug.LogError("Player transform is not assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (geiko != null && player != null)
        {
            geiko.SetDestination(player.position);
        }
    }
}