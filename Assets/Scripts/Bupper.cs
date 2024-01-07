using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bupper : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    private Vector3 _directionIntent;
    public int force;
    
    private void OnTriggerEnter(Collider other)
    {
        playerRigidBody.AddForce(
            Vector3.up * force, ForceMode.VelocityChange
        );
    }
}
