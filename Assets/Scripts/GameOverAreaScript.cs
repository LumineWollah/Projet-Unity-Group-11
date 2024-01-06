using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverAreaScript : MonoBehaviour
{
    public Collider Player;
    private void OnTriggerEnter(Collider other)
    {
        if(other == Player){
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("YouLostMenu");
        }
    }
}