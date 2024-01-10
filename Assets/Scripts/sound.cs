using UnityEngine;

public class BombeScript : MonoBehaviour
{
    public AudioClip explosionSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("PlayerRoot"))
        {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        }
    }
}