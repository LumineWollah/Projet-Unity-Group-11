using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class Teleportation : MonoBehaviour
{
    public GameObject teleportTarget;
    public GameObject player;
    public AudioClip sound;
 
   
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        player.transform.position = teleportTarget.transform.position;
    }
}
