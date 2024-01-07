using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;


public class SwitchObjectBlue : MonoBehaviour
{
    private bool _IsActive ;
    public GameObject ObjectBlue;
    public GameObject ObjectBlueEmpty;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(_IsActive == true)
            { ObjectBlue.SetActive(true); 
                ObjectBlueEmpty.SetActive(false); 
                _IsActive = false;
            }
            else
            {
                ObjectBlue.SetActive(false); 
                ObjectBlueEmpty.SetActive(true); 
                _IsActive = true;
            }
        }
    }
}