using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;


public class SwitchObjectRed : MonoBehaviour
{
    private bool _IsActive ;
    public GameObject ObjectRed;
    public GameObject ObjectRedEmpty;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(_IsActive == true)
            { ObjectRed.SetActive(true); 
                ObjectRedEmpty.SetActive(false); 
                _IsActive = false;
            }
            else
            {
                ObjectRed.SetActive(false); 
                ObjectRedEmpty.SetActive(true); 
                _IsActive = true;
            }
        }
    }
}
