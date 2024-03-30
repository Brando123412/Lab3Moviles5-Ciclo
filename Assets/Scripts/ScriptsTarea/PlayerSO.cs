using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "ScriptableObjects/PlayerSO", order = 1)]
public class PlayerSO : ScriptableObject
{
    public float speedY { get; private set; }
    public float speedX { get; private set; }
    public Sprite spriteJugador { get; private set; }
    public void SavePlayer(float speedx, float speedy, Sprite JugadorSprite)
    {
        speedX = speedx;
        speedY = speedy;
        spriteJugador = JugadorSprite;
    }
}
