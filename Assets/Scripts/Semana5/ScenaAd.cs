using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenaAd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Results",LoadSceneMode.Additive);
        Invoke("UnloadScene",3.5f);
    }

    public void UnloadScene()
    {
        // Descargar la escena
        SceneManager.UnloadScene("AdditiveScene");
    }
}
