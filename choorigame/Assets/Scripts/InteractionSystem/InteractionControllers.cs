using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractionControllers : MonoBehaviour
{
    
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private InteractionPromptUI _interactionPromptUI;
    [SerializeField] float range;
    private bool clueActivated = false;
    private RaycastHit hitinfo;
    [SerializeField] Text actionText;
    private IInteractable _interactable;
    [SerializeField] Inventory theInventory;

    private void Update(){
        // RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitinfo, range, _interactableMask)){
            Debug.Log("function called3");
            _interactable = hitinfo.collider.GetComponent<IInteractable>();
            if(_interactable != null){
                Debug.Log("function called2");
                if (Keyboard.current.eKey.wasPressedThisFrame){
                    Debug.Log("function called1");
                    _interactionPromptUI.SetUp(_interactable.InteractionPrompt, _interactable.InteractionName);
                    _interactable.Interact(this);
                }
            }
        }
        else{
            Debug.Log("function called4");
            if (_interactable != null) _interactable = null;
            if (_interactionPromptUI.IsDisplayed) _interactionPromptUI.Close();
        }

        if(SceneManager.GetActiveScene().name == "scene2"){
            CheckClue();
            TryAction();
        }
    }

    private void TryAction(){
        if(Input.GetKeyDown(KeyCode.E)){
            CheckClue();
            CanPickUp();
        }
    }

    private void CheckClue(){
        if(Physics.Raycast(transform.position, transform.forward, out hitinfo, range, _interactableMask)){
            if(hitinfo.transform.tag == "Clue"){
                ClueInfoAppear();
            }
        }
        else ClueInfoDisappear();
    }

    private void ClueInfoAppear(){
        clueActivated = true;
        actionText.gameObject.SetActive(true);
        actionText.text = "press <E>";
    }   

    private void ClueInfoDisappear(){
        clueActivated = false;
        actionText.gameObject.SetActive(false);
    }

    private void CanPickUp(){
        if(clueActivated){
            if(hitinfo.transform != null){
                Debug.Log(hitinfo.transform.GetComponent<CluePickUp>().clue.clueName + " 단서 획득");
                hitinfo.transform.tag = "Untagged";
                theInventory.AcquireClue(hitinfo.transform.GetComponent<CluePickUp>().clue);
                ClueInfoDisappear();
            }
        }
    }

}
