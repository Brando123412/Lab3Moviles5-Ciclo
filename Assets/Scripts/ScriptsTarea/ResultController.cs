using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ResultController : MonoBehaviour
{

    [SerializeField] TMP_Text[] textsScore;
    public void IrAMenu()
    {
        SceneManager.LoadScene(0);
    }
}
