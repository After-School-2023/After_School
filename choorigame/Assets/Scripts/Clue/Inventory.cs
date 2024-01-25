using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public static bool inventoryActivated = false;
    [SerializeField] private GameObject go_InventoryBase;
    [SerializeField] private GameObject go_SlotsParent;
    private Slot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        TryOpenInventory();
        
    }

    private void TryOpenInventory(){
        if(Input.GetKeyDown(KeyCode.C)){
            inventoryActivated = !inventoryActivated;
            if(inventoryActivated){
                OpenInventory();
            } else{
                CloseInventory();
            }
        }
    }

    private void OpenInventory(){
        go_InventoryBase.SetActive(true);
    }

    private void CloseInventory(){
        go_InventoryBase.SetActive(false);
    }

    public void AcquireClue(Clue _clue, int _count = 1){
        for (int i=0; i<slots.Length; i++){
            if(slots[i].clue == null){
                slots[i].AddClue(_clue, _count);
                if(i == 4){
                    Invoke("LoadSceneWithDelay", 5);
                }
                return;
            }
        }
    }

    private void LoadSceneWithDelay(){
        SceneManager.LoadScene("scene3");
    }
}
