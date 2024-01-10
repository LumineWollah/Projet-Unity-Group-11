using UnityEngine;
using UnityEngine.Events;


public class DisactivateLazer : MonoBehaviour
{
    public GameObject delete;
    
    public UnityEvent activated;
    public Material activatedMaterial;
    public MeshRenderer meshRenderer;

    private bool _activatedState;
    public AudioClip sound;

    public void ToggleButton()
    {
        _activatedState = !_activatedState;
        if (_activatedState)
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            meshRenderer.material = activatedMaterial;
            activated.Invoke();
            DestroyImmediate(delete);
        }
    }
}

