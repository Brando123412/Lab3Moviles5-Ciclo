using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ResultController : MonoBehaviour
{

    [SerializeField] TMP_Text[] textsScore;
    int[] curretValue;
    void OnEnable()
    {
        curretValue = SceneGlobalManager.Instance.puntaje.ReturmArray();
        for (int i = curretValue.Length - 1; i >= 0; i--)
        {
            textsScore[i].text = "Score: " + curretValue[i].ToString();
        }
    }
    public void IrAMenu()
    {
        SceneGlobalManager.Instance.DescargarEscenas();
    }
}
