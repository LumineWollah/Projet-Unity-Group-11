using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverDeadzoneScript : MonoBehaviour
{
    public GameObject playerRoot;
    public Collider Player;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}