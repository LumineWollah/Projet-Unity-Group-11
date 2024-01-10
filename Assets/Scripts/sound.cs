using UnityEngine;

public class soundTouch : MonoBehaviour
{
    public AudioClip sound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("PlayerRoot") || collision.gameObject.name.Equals("VisualBody"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}