using UnityEngine;
using UnityEngine.Events;


public class DisactivateLazer : MonoBehaviour
{
    public GameObject delete;
    
    public UnityEvent activated;
    public Material activatedMaterial;
    public MeshRenderer meshRenderer;

    private bool _activatedState;

    public void ToggleButton()
    {
        _activatedState = !_activatedState;
        if (_activatedState)
        {
            meshRenderer.material = activatedMaterial;
            activated.Invoke();
            DestroyImmediate(delete);
        }
    }
}

