using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clue", menuName = "New Clue/clue")]
public class Clue : ScriptableObject
{
    public string clueName;
    public Sprite clueImage;
    public string clue;
    public GameObject cluePrefab;
}
