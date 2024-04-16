using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenaAd : MonoBehaviour
{
   
    void Start()
    {
        SceneManager.LoadScene("Results",LoadSceneMode.Additive);
        Invoke("UnloadScene",3.5f);
    }

    public void UnloadScene()
    {
        // Descargar la escena
        SceneManager.UnloadSceneAsync("AdditiveScene");
    }
}
