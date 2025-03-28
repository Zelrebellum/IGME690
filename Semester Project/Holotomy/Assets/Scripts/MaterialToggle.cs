using LookingGlass;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialToggle : MonoBehaviour
{
    [SerializeField] List<Material> materials;

    GameObject gObject;
    int matIndex;
    // Start is called before the first frame update
    void Start()
    {
        gObject = GetComponent<GameObject>();
        matIndex = Random.Range(0, materials.Count-1);
        gObject.GetComponent<Renderer>().material = materials[matIndex];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(matIndex>=materials.Count)
        {
            matIndex = 0;
        }
        else
        {
            matIndex++;
        }

        if (InputManager.GetButtonDown(HardwareButton.Forward))
        {
            gObject.GetComponent<Renderer>().material = materials[matIndex];
        }
        
    }
}
