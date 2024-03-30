using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;
    [SerializeField] PlayerController playerController;
    private void Awake()
    {
        SetPlayer();
    }
    void SetPlayer()
    {
        playerController.speedX = playerSO.speedX;
        playerController.speedY = playerSO.speedY;
        playerController.spriteJugador = playerSO.spriteJugador;
    }
}
