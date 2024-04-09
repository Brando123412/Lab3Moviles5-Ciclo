using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ResultController : MonoBehaviour
{

    [SerializeField] TMP_Text[] textsScore;
    [SerializeField] InsertionSort SOCore;
    int[] curretValue;
    void Awake()
    {
        curretValue = SOCore.ReturmArray();
    }
    void Start()
    {
        for (int i = curretValue.Length - 1; i >= 0; i--)
        {
            textsScore[i].text = "Score: "+curretValue[i].ToString();
        }
    }
    public void IrAMenu()
    {
        SceneManager.LoadScene(0);
    }
}
