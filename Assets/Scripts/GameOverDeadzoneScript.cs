using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverDeadzoneScript : MonoBehaviour
{
    public GameObject playerRoot;
    public Collider Player;
    private void OnTriggerEnter(Collider other)
    {
        if (QuakeLikeFPSScript.hp > 1) {
            QuakeLikeFPSScript.hp--;
            playerRoot.transform.position = new Vector3(0, 1, 0);
        } else {
            if(other == Player){
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("YouLostMenu");
            }
        }
    }
}