using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;

    public void PlayerSeleccionado(PlayerController playerController)
    {
        playerSO.SavePlayer(playerController.speedX, playerController.speedY, playerController.spriteJugador);
    }

}
