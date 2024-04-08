using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObjectBullet : MonoBehaviour
{
    ObjectPolling pollingReferences;
    [SerializeField] float speed;
    Rigidbody2D rb2d;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
    }
    private void OnEnable()
    {
        rb2d.velocity = Vector3.right * speed;
    }
    public void SetRefencesPolling(ObjectPolling references)
    {
        pollingReferences = references;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.tag == "Basuras")
        {
            pollingReferences.SetObject(this.gameObject);
        }

        if (collision.tag == "Collector")
        {
            pollingReferences.SetObject(this.gameObject);
        }
    }
}
