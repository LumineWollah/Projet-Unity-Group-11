using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverAreaScript : MonoBehaviour
{
    public Collider Player;
    private void OnTriggerEnter(Collider other)
    {
        if (QuakeLikeFPSScript.hp > 1) {
            QuakeLikeFPSScript.hp--;
        } else {
            if(other == Player){
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("YouLostMenu");
            }
        }
    }
}