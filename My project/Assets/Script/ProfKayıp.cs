using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfKay�p : MonoBehaviour
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

