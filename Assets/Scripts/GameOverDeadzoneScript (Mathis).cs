using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverDeadzoneScript : MonoBehaviour
{
    public GameObject playerRoot;
    public Collider Player;
    private void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("YouLostMenu");
    }
}