using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class dead_body_1 : MonoBehaviour, IInteractable
{   
    [SerializeField] private string _prompt;
    void Start(){
    }
    public string InteractionPrompt{
        get{
            return _prompt;
        }
    }

    public string InteractionName{
        get{
            return "마에시마";
        }
    }

    public bool Interact (InteractionControllers interactor){
        Debug.Log("dead_body");
        return true;
    }

}
