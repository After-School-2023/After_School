using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoorController2 : MonoBehaviour
{
    public Animator doorAnimator1;
    private bool isOpen1 = false;
    public float interactionRange = 1f;

    // Start is called before the first frame update
    void Start()
    {
        if (doorAnimator1 == null)
        {
            Debug.LogError("Animator is not assigned! Please assign the Animator component in the Inspector.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distanceDoor1 = Vector3.Distance(transform.position, doorAnimator1.transform.position);

            if (distanceDoor1 <= interactionRange)
            {
                if (!isOpen1)
                {
                    doorAnimator1.SetTrigger("DoorOpen1");
                }
                else
                {
                    doorAnimator1.SetTrigger("DoorClose1");
                }
                isOpen1 = !isOpen1;
            }

            
        }

        
    }
}