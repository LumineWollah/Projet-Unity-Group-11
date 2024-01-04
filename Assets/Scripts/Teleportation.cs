using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class Teleportation : MonoBehaviour
{
    public GameObject teleportTarget;
    public GameObject player;
 
   
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
    }
}
