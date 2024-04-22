using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;

    public void PlayerSeleccionado(PlayerController playerController)
    {
        playerSO.SavePlayer(playerController.speedX, playerController.speedY, playerController.vida, playerController.spriteJugador);
    }
    public void IrAGame()
    {
        if (playerSO.spriteJugador != null)
        {
            SceneGlobalManager.Instance.SelectionAndGame();
        }
        
    }

}
