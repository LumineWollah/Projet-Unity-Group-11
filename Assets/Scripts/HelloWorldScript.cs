using UnityEngine;

public class HelloWorldScript : MonoBehaviour
{
    [SerializeField]
    private string customMessage;
    
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log($"Hello les 2 ESGI ! o/ Vous {customMessage}");
    }

    // Update is called once per frame
    void Update()
    {
    }
}