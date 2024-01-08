using UnityEngine;

public class DashPlatform : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    private Vector3 _directionIntent;
    public float dashForce = 10f;

    private void OnTriggerEnter(Collider other)
    {
            _directionIntent = transform.right;
            playerRigidbody.AddForce(_directionIntent * dashForce, ForceMode.VelocityChange);
    }
}