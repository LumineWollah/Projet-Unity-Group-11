using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public string sceneToLoad;
    public static string level;

    public void LoadScene()
    {
        level = sceneToLoad;
        SceneManager.LoadScene(sceneToLoad);
    }
}