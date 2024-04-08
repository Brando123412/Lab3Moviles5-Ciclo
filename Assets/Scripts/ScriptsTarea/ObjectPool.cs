using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> objectPool;  
    public GameObject objecPrefab;
    public int maxQuantity;

    private void Start()
    {
        
    }
    public void InstantiateObjects()
    {
        GameObject tmp;
        for (int i = 0;i<maxQuantity; i++)
        {
            tmp = Instantiate(objecPrefab,transform.position, Quaternion.identity, transform);
            objectPool.Add(tmp);
            tmp.SetActive(false); 
        }
    }
    public void GetObject(Vector3 referencesPosition)
    {
        if(objectPool.Count > 0)
        {
            GameObject tmp = objectPool[0];
            objectPool.Remove(tmp);
            tmp.transform.position =referencesPosition;
            tmp.SetActive(true);
        }else
        {
            print("no hay objetos en el pool");
        }
    }
    public void SetObject(GameObject obj)
    {
        objectPool.Add(obj);
    }

}
