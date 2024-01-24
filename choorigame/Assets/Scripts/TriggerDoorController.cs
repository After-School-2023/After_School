using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoorController : MonoBehaviour
{
    public Animator doorAnimator2;
    private bool isOpen2 = false;
    public float interactionRange = 1f;

    // 연타 감지 변수
    private int consecutiveKeyPressCount = 0;
    private bool isBreakingDoor2 = true;

    // Start is called before the first frame update
    void Start()
    {
        if (doorAnimator2 == null)
        {
            Debug.LogError("Animator is not assigned! Please assign the Animator component in the Inspector.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distanceDoor2 = Vector3.Distance(transform.position, doorAnimator2.transform.position);

            if (distanceDoor2 <= interactionRange)
            {   

                if (!isOpen2)
                {
                    
                    // 연타 횟수 증가
                    if (isBreakingDoor2)
                    {
                        consecutiveKeyPressCount++;
                    }
                    else
                    {
                        // 연타가 아니면 초기화
                        consecutiveKeyPressCount = 0;
                    }

                    // DoorBreak2를 연타 횟수에 따라 처리
                    if (consecutiveKeyPressCount < 5)
                    {
                        doorAnimator2.SetTrigger("DoorOpen2");
                    }
                    else
                    {
                        doorAnimator2.SetTrigger("DoorBreak2");
                        isBreakingDoor2 = true;
                        isOpen2 = true;
                    }
                }
                else
                {
                    isBreakingDoor2 = false;
                }
                
            }
        }

        
    }
}