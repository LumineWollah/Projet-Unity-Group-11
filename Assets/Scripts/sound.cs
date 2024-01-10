using UnityEngine;

public class soundTouch : MonoBehaviour
{
    public AudioClip sound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("PlayerRoot"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}