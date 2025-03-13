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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        KeyCheckV2(sceneTop,HardwareButton.Back);
        KeyCheckV2(sceneMiddle, HardwareButton.Forward);
        KeyCheckV2(sceneBottom, HardwareButton.PlayPause);
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
