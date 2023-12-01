using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public UnityEvent activated;
    public UnityEvent deactivated;
    public Material activatedMaterial;
    public Material deactivatedMaterial;
    public MeshRenderer meshRenderer;

    private bool activatedState;

    public void ToggleButton()
    {
        activatedState = !activatedState;
        if (activatedState)
        {
            meshRenderer.material = activatedMaterial;
            activated.Invoke();
        }
        else
        {
            meshRenderer.material = deactivatedMaterial;
            deactivated.Invoke();
        }
    }
}