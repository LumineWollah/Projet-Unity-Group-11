using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScript : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("T nul lol");
        triggerEnterEvent.Invoke();
    }
}
