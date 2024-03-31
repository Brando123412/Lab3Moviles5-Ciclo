using System;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ObjectPooling", menuName = "ScriptableObjects/SimpleObjectPooling", order = 0)]
public class SimpleObjectPooling : ScriptableObject
{
    [SerializeField] private GameObject[] objectPrefab;
    private Queue<GameObject> objectPool;

    private Transform parentTransform;

    public event Action onEnableObject;

    public void SetUp(Transform parent)
    {
        if(objectPool == null)
        {
            objectPool = new Queue<GameObject>();
        }

        objectPool.Clear();
        parentTransform = parent;
    }

    public GameObject GetObject(Transform objetcSave)
    {
        GameObject objectInstance = null;
        int randomPosition = UnityEngine.Random.Range(-4, 4);
        Vector3 positionSpanw = new Vector3(12, randomPosition, 0);

        if (objectPool.Count > 0)
        {

            objectInstance = objectPool.Dequeue();
            objectInstance.transform.position = positionSpanw;
            objectInstance.SetActive(true);
            onEnableObject?.Invoke();
        }
        else
        {
            int randomEnemy = UnityEngine.Random.Range(0, objectPrefab.Length-1);
            objectInstance = Instantiate(objectPrefab[randomEnemy], positionSpanw, Quaternion.identity,objetcSave);
            objectInstance.SetActive(true);
            onEnableObject?.Invoke();
        }
        return objectInstance;
    }

    public void ObjectReturn(GameObject objectInstance)
    {
        objectInstance.SetActive(false);
        objectInstance.transform.position = parentTransform.position;
        objectPool.Enqueue(objectInstance);
    }
}
