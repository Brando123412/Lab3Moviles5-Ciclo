using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private SimpleObjectPooling myPooling;
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] public float speed;
    [SerializeField] private int hit;
    private bool isSetUp;
    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        myPooling.onEnableObject += SetUp;
    }

    private void OnDisable()
    {
        myPooling.onEnableObject -= SetUp;
    }

    private void SetUp()
    {
        if (!isSetUp)
        {
            if(myRigidbody == null)
            {
                myRigidbody = GetComponent<Rigidbody2D>();
            }

            myRigidbody.velocity = Vector3.left * speed;

            isSetUp = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.tag == "Player")
        {
            collision.GetComponent<PlayerController>().vida -= hit;   
            isSetUp = false;
            myPooling.ObjectReturn(this.gameObject);
        }

        if(collision.tag == "Collector")
        {
            isSetUp = false;
            myPooling.ObjectReturn(this.gameObject);
        }
    }
}
