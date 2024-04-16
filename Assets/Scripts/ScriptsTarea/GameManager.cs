using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;
    [SerializeField] PlayerController playerController;
    
    public static float puntajeValue;
    [SerializeField] TMP_Text scoreActual;
    private void Awake()
    {
        SetPlayer();
    }
    private void Update()
    {
        puntajeValue = puntajeValue + Time.deltaTime;   
        if (playerController.vida < 0)
        {
            SceneGlobalManager.Instance.resutlSceneGO.SetActive(true);
            SceneGlobalManager.Instance.gameSceceGO.SetActive(false);
            SceneGlobalManager.Instance.puntaje.SavePuntaje((int)puntajeValue);
        }
        scoreActual.text = "Puntaje: "+Mathf.Round(puntajeValue).ToString();
    }
    void SetPlayer()
    {
        playerController.speedX = playerSO.speedX;
        playerController.speedY = playerSO.speedY;
        playerController.vida = playerSO.live;
        playerController.GetComponent<SpriteRenderer>().sprite = playerSO.spriteJugador;
    }
}
