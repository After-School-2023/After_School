using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoorControllerSearching : MonoBehaviour
{
    public Animator doorAnimator1;
    public Animator doorAnimator2;
    private bool isOpen1 = false;
    private bool isOpen2 = false;
    public float interactionRange = 1f;

    // 연타 감지 변수
    private int consecutiveKeyPressCount = 0;
    private bool isBreakingDoor2 = true;

    // Start is called before the first frame update
    void Start()
    {
        if (doorAnimator1 == null || doorAnimator2 == null)
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
            float distanceDoor2 = Vector3.Distance(transform.position, doorAnimator2.transform.position);

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

            if (distanceDoor2 <= interactionRange)
            {
                if (!isOpen2)
                {
                    doorAnimator2.SetTrigger("DoorOpen3");
                }
                else
                {
                    doorAnimator2.SetTrigger("DoorClose3");
                }
                isOpen2 = !isOpen2;
            }
        }

        
    }
}