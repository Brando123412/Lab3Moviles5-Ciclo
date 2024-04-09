using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObjectBullet : MonoBehaviour
{
    ObjectPolling pollingReferences;
    [SerializeField] float speed;
    Rigidbody2D rb2d;
    ObjectPool poolReferences;
    [SerializeField] int hit;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        if(tag == "Bullet")
        {
            rb2d.velocity = Vector3.right * speed;
        }
        else
        {
            rb2d.velocity = Vector3.left * speed;
        }     
        
    }
    public void SetRefencesPolling(ObjectPolling references)
    {
        pollingReferences = references;
    }
    public void SetRefencesPolling(ObjectPool references)
    {
        poolReferences = references;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Bullet" && this.tag == "Basura")
        {
            poolReferences.SetObject(this.gameObject);      
        }

        if (collision.tag == "Basura" && this.tag == "Bullet")
        {
            pollingReferences.SetObject(this.gameObject);
            GameManager.puntajeValue += 10;
        }
        if ((this.tag == "Alien" || this.tag == "Basura") && collision.CompareTag("Player"))
        {
            poolReferences.SetObject(this.gameObject);
            collision.GetComponent<PlayerController>().vida -= hit;
        }
        
        if (collision.tag == "Collector")
        {
            if (this.tag == "Bullet")
            {
                pollingReferences.SetObject(this.gameObject);
            }
            else
            {
                poolReferences.SetObject(this.gameObject);
            }
        }
    }
}
