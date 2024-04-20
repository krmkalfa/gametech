using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController3 : MonoBehaviour
{
    public string Scene;


    public float waitTime = 3f; // Bekleme s�resi (saniye cinsinden)


    public void OnButtonClick()
    {
        // Belirtilen s�re kadar bekle ve sonra sahneyi y�kle
        Invoke("LoadSceneAfterDelay", waitTime);
    }

    void LoadSceneAfterDelay()
    {
        // Sahneyi y�kle
        SceneManager.LoadScene(Scene);
    }
}
