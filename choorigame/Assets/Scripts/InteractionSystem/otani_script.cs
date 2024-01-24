using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class otani_script : MonoBehaviour, IInteractable
{
    [SerializeField] private string[] _prompt;
    private int cnt = 0;
    public string InteractionPrompt{
        get{
            if(cnt < _prompt.Length){
                string prompt = _prompt[cnt];
                cnt++;
                return prompt;
            }
            else{
                return "그럼 수고하세요.";
            }
        }
    }

    public string InteractionName{
        get{
            return "오타니 형사";
        }
    }

    public bool Interact (InteractionControllers interactor){
        Debug.Log("otani");
        return true;
    }
}
