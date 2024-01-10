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
    public AudioClip sound;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
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