using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class dead_body : MonoBehaviour, IInteractable
{   
    public SceneSwitcher sceneSwitcher;
    [SerializeField] private string _prompt;
    void Start(){
        if (sceneSwitcher == null){
            sceneSwitcher = FindObjectOfType<SceneSwitcher>();
        }
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
        StartCoroutine(WaitAndSwitchScene(2f));
        return true;
    }

    private IEnumerator WaitAndSwitchScene(float waitTime){
        yield return new WaitForSeconds(waitTime);
        sceneSwitcher.SwitchToScene2();
    }

}
