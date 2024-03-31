using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "ScriptableObjects/PlayerSO", order = 1)]
public class PlayerSO : ScriptableObject
{
    public float speedY;
    public float speedX;
    public int live;
    public Sprite spriteJugador;

    public void SavePlayer(float speedx, float speedy, int live1, Sprite JugadorSprite)
    {
        speedX = speedx;
        speedY = speedy;
        live = live1;    
        spriteJugador = JugadorSprite;

    }
}
