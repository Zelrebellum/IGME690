using LookingGlass;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialToggle : MonoBehaviour
{
    [SerializeField] List<Material> materials;

    [SerializeField] GameObject gObject;
    int matIndex;
    // Start is called before the first frame update
    void Start()
    {
        matIndex = Random.Range(0, materials.Count-1);
        gObject.GetComponent<Renderer>().material = materials[matIndex];
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (InputManager.GetButtonDown(HardwareButton.Forward))
        {
            if (matIndex >= materials.Count - 1)
            {
                matIndex = 0;
            }
            else
            {
                matIndex++;
            }
            gObject.GetComponent<Renderer>().material = materials[matIndex];
        }
        
    }
}
