using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class geiko : MonoBehaviour, IInteractable
{
    [SerializeField] private string[] _prompt;
    private System.Random random = new System.Random();
    public string InteractionPrompt{
        get{
            if (_prompt.Length > 0)
            {
                int randomIndex = random.Next(0, _prompt.Length);
                return _prompt[randomIndex];
            }
            else
            {
                return "그럼 수고하세요.";
            }
        }
    }

    public string InteractionName{
        get{
            return "게이코";
        }
    }

    public bool Interact (InteractionControllers interactor){
        Debug.Log("otani");
        return true;
    }
}
