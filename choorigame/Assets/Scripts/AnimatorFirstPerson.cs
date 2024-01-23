using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFirstPerson : MonoBehaviour
{
    public Animator rightHandAnimator;
    // public Animator leftHandAnimator;

    private bool punch = false; //keboard 1
    private bool grab = false; //keyboard 2
    private bool boo = false; // keyboard 3
    private bool beckon = false; // keyboard 4

    // Start is called before the first frame update
    void Start()
    {
        if (rightHandAnimator == null)
        {
            Debug.LogError("Animator is not assigned! Please assign the Animator component in the Inspector.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!punch)
            {
                rightHandAnimator.SetTrigger("rightPunch");
            }
            else
            {
                rightHandAnimator.SetTrigger("rightPunch");
            }
            punch = !punch;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!grab)
            {
                rightHandAnimator.SetTrigger("rightGrab");
            }
            else
            {
                rightHandAnimator.SetTrigger("rightGrab");
            }
            grab = !grab;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (!boo)
            {
                rightHandAnimator.SetTrigger("rightBoo");
            }
            else
            {
                rightHandAnimator.SetTrigger("rightBoo");
            }
            boo = !boo;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (!beckon)
            {
                rightHandAnimator.SetTrigger("rightBeckon");
            }
            else
            {
                rightHandAnimator.SetTrigger("rightBeckon");
            }
            beckon = !beckon;
        }
    }
}
