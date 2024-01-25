using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public int scene1Index;
    public int scene2Index;
    public int scene3Index;
    // Start is called before the first frame update
    void Start()
    {
        // SceneManager.LoadScene(scene1Index);
    }

    // Update is called once per frame
    public void SwitchToScene2()
    {
        SceneManager.LoadScene(scene2Index);
    }

    public void SwitchToScene3(){
        SceneManager.LoadScene(scene3Index);
    }
}
