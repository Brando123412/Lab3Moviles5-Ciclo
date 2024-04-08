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
            tmp = Instantiate(objecPrefab);
            //tmp.GetComponent<Squ>().SetObjectPool(this);
            objectPool.Add(tmp);
            
        }
    }

}
