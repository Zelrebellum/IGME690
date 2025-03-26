using LookingGlass;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tempSceneChange : MonoBehaviour
{
    [SerializeField]
    string sceneTop;
    [SerializeField] 
    string sceneMiddle;
    [SerializeField]
    string sceneBottom;

    [SerializeField] bool isOnTop;
    [SerializeField] bool isOnMiddle;
    [SerializeField] bool isOnBottom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOnTop) { KeyCheckV2(sceneTop, HardwareButton.Back); }
        if (isOnMiddle) { KeyCheckV2(sceneMiddle, HardwareButton.Forward); }
        if (isOnBottom) { KeyCheckV2(sceneBottom, HardwareButton.PlayPause); }
    }

    private void keyCheck()
    {
        if (InputManager.GetButtonDown(HardwareButton.Back))
        {
            if(sceneTop != null)
            {
                SceneManager.LoadScene(sceneTop);
            }
        }
        else if (InputManager.GetButtonDown(HardwareButton.Forward))
        {
            if (sceneMiddle != null)
            {
                SceneManager.LoadScene(sceneMiddle);
            }
        }
        else if (InputManager.GetButtonDown(HardwareButton.PlayPause))
        {
            if(sceneBottom!=null)
            {
                SceneManager.LoadScene(sceneBottom);
            }
        }
    }

    private void KeyCheckV2(string scene, HardwareButton button)
    {
        if(scene != null)
        {
            if(InputManager.GetButtonDown(button))
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
}
