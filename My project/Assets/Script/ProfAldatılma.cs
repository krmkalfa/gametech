using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfAldatılma : MonoBehaviour
{
    public string sceneName;
    public float delay = 5f; // Bekleme süresi

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

