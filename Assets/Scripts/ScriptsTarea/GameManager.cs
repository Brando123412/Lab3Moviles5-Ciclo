using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;
    [SerializeField] PlayerController playerController;
    [SerializeField] InsertionSort puntaje;
    float puntajeValue;
    private void Awake()
    {
        SetPlayer();
    }
    private void Update()
    {
        puntajeValue = puntajeValue + Time.deltaTime;   
        if (playerController.vida < 0)
        {
            SceneManager.LoadScene(2);
            puntaje.SavePuntaje((int)puntajeValue);
        }
    }
    void SetPlayer()
    {
        playerController.speedX = playerSO.speedX;
        playerController.speedY = playerSO.speedY;
        playerController.vida = playerSO.live;
        playerController.GetComponent<SpriteRenderer>().sprite = playerSO.spriteJugador;
    }
}
