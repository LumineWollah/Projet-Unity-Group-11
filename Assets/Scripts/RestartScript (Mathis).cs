using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene(LoadSceneScript.level);
    }
}
