using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class lockedDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt1;
    [SerializeField] private string _prompt2;
    [SerializeField] private string _prompt3;
    [SerializeField] private string _prompt4;
    [SerializeField] private string _prompt5;
    public int cnt = 0;
    
    public string InteractionPrompt{
        get{
            if (cnt == 0){   
                cnt++;
                return _prompt1;
            } else if (cnt == 1){
                cnt++;
                return _prompt2;
            } else if (cnt == 2){
                cnt++;
                return _prompt3;
            } else if (cnt == 3){
                cnt++;
                return _prompt4;
            } else if (cnt == 4){
                cnt++;
                return _prompt5;
            } else{
                // Handle additional cases if needed
                return "문이 부서졌다.";
            }
        }
    }

    public string InteractionName{
        get{
            return "마에시마";
        }
    }

    public bool Interact (InteractionControllers interactor){
        Debug.Log("locked door");
        return true;
    }

}
