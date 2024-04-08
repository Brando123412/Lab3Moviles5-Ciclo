using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedY;
    public float speedX;
    public Sprite spriteJugador;
    public int vida;
    public bool jugable = false;
    float velX;
    float velY;

    bool canShot;
    private void Update()
    {
        if (jugable)
        {
            Moverse();
        }
    }
    void Moverse(){
        velX = Mathf.Clamp(velX +=Input.acceleration.x * speedX,-9.5f,9.5f);
        velY = Mathf.Clamp(velY += -Input.acceleration.y * speedX, -4.35f, 4.35f);
        transform.position = new Vector3(velX, velY, 0);
    }

}
