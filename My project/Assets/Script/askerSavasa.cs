using UnityEngine;
using UnityEngine.SceneManagement;

public class askerSavasa : MonoBehaviour
{
    public string sceneName;
    public float delay = 5f; // Bekleme s�resi

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

