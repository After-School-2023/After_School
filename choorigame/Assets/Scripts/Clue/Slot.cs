using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour
{
    public Clue clue;
    public int clueCount;
    public Image clueImage;
    
    //clueImage 투명도 조절
    private void SetColor(float _alpha){
        Color color = clueImage.color;
        color.a = _alpha;
        clueImage.color = color;
    }

    //인벤토리에 새로운 슬롯 추가
    public void AddClue(Clue _clue, int _count = 1){
        clue = _clue;
        clueCount = _count;
        clueImage.sprite = clue.clueImage;

        SetColor(255);
        Debug.Log("Add Clue Function");
    }

}
