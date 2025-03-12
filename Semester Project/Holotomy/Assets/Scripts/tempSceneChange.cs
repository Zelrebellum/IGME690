using LookingGlass;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tempSceneChange : MonoBehaviour
{
    [SerializeField]
    private string scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyCheck();
    }

    private void keyCheck()
    {
        if (InputManager.GetButtonDown(HardwareButton.Back))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
