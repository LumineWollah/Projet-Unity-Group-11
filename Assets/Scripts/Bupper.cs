using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bupper : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    private Vector3 _directionIntent;
    public int force;
    public AudioClip sound;
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        playerRigidBody.AddForce(
            Vector3.up * force, ForceMode.VelocityChange
        );
    }
}
