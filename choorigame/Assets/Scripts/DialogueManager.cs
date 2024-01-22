using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    [SerializeField] GameObject go_dialogueBar;
    [SerializeField] GameObject go_NameBar;
    [SerializeField] TMP_Text txt_dialogue;
    [SerializeField] TMP_Text txt_name;
    bool isDialogue = false;

    public void ShowDialogue(){
        txt_dialogue.text = "";
        txt_name.text = "";
        SettingUI(true);
    }

    void SettingUI(bool p_flag){
        go_dialogueBar.SetActive(p_flag);
        go_NameBar.SetActive(p_flag);
    }
}
