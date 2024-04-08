using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanShotPlayer : MonoBehaviour
{
    [SerializeField] private SimpleObjectPooling myPooling;

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
    private void PrintBulletCount()
    {
        _countBullets++;
        Debug.Log(gameObject.name + ": " + _countBullets);
    }
}
