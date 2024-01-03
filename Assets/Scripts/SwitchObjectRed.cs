using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;


public class SwitchObjectRed : MonoBehaviour
{
    public bool isActive = true ;
    public GameObject ObjectRed;
    public GameObject ObjectRedEmpty;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(isActive == true)
            {
                ObjectRed.SetActive(true); 
                ObjectRedEmpty.SetActive(false); 
                isActive = false;
            }
            else
            {
                ObjectRed.SetActive(false); 
                ObjectRedEmpty.SetActive(true); 
                isActive = true;
            }
        }
    }
}
