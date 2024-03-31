using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwEnemys : MonoBehaviour
{
    [SerializeField] private SimpleObjectPooling myPooling;
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private bool canShoot;

    private float _count = 0f;
    private int _countBullets = 0;

    private void Awake()
    {
        myPooling.SetUp(this.transform);
    }
    void OnEnable()
    {
        myPooling.onEnableObject += PrintBulletCount;
    }

    private void OnDisable()
    {
        myPooling.onEnableObject -= PrintBulletCount;
    }
    void Update()
    {
        _count += Time.deltaTime;

        if (_count > fireRate && canShoot)
        {
            myPooling.GetObject(this.transform);

            _count = 0;
        }
    }


    private void PrintBulletCount()
    {
        _countBullets++;
        Debug.Log(gameObject.name + ": " + _countBullets);
    }
}
