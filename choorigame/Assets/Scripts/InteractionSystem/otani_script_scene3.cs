using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class otani_script_scene3 : MonoBehaviour, IInteractable
{
    [SerializeField] private string[] _prompt;
    [SerializeField] private string[] _name;
    private int cnt = 0;
    public string InteractionPrompt{
        get{
            if(cnt < _prompt.Length){
                string prompt = _prompt[cnt];
                cnt++;
                return prompt;
            }
            else{
                return "....";
            }
        }
    }

    public string InteractionName{
        get{
            if(cnt-1 < _name.Length){
                string name = _name[cnt-1];
                return name;
            }
            else{
                return "....";
            }
        }
    }

    public bool Interact (InteractionControllers interactor){
        Debug.Log("otani");
        return true;
    }
}
