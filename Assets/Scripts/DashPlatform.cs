using UnityEngine;

public class DashPlatform : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    private Vector3 _directionIntent;
    public float dashForce = 10f;
    public AudioClip sound;

    private void OnTriggerEnter(Collider other)
    {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            _directionIntent = transform.right;
            playerRigidbody.AddForce(_directionIntent * dashForce, ForceMode.VelocityChange);
            
    }
}