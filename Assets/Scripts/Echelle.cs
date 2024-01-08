using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Echelle : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody playerRigidBody;

    private void OnTriggerStay(Collider other)
    {
        float mouvementVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(0f, mouvementVertical, 0f) * Speed * Time.deltaTime;
        other.transform.Translate(mouvement);
        
    }
    
}