using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InteractionControllers : MonoBehaviour
{
    
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private InteractionPromptUI _interactionPromptUI;
    
    private IInteractable _interactable;

    private void Update(){
        RaycastHit hit;
        
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, _interactableMask)){

            _interactable = hit.collider.GetComponent<IInteractable>();
            if(_interactable != null){
                if (Keyboard.current.eKey.wasPressedThisFrame){
                    _interactionPromptUI.SetUp(_interactable.InteractionPrompt, _interactable.InteractionName);
                    _interactable.Interact(this);
                }
            }
        }
        else{
            if (_interactable != null) _interactable = null;
            if (_interactionPromptUI.IsDisplayed) _interactionPromptUI.Close();
        }
    }
    
}
