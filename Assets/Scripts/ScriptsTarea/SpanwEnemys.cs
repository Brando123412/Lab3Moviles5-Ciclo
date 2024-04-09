using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwEnemys : MonoBehaviour
{
    private float fireRate = 1f;

    [SerializeField] ObjectPool poolReference;
    [SerializeField]float _count;
    Vector3 posReference;
    float randomValue;
    void Update()
    {
        _count += Time.deltaTime;

        if (_count > fireRate )
        {
            randomValue = Random.Range(-4.5f,4.5f);
            posReference = new Vector3(11.5f,randomValue,0);
            poolReference.GetObject(posReference);
            _count = 0;   print("Hola");
        }
    }
}
