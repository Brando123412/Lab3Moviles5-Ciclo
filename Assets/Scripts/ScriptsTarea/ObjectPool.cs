using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> objectPool1;
    public PoolObjectBullet[] objecPrefab;
    public int maxQuantity;

    private void Start()
    {
        InstantiateObjects();
    }
    public void InstantiateObjects()
    {
        GameObject tmp;
        int randomValue;
        for (int i = 0;i<maxQuantity; i++)
        {
            randomValue = Random.Range(0,objecPrefab.Length);
            tmp = Instantiate(objecPrefab[randomValue].gameObject,transform.position, Quaternion.identity, transform);
            tmp.GetComponent<PoolObjectBullet>().SetRefencesPolling(this);
            tmp.SetActive(false);
            objectPool1.Add(tmp);
        }
    }
    public void GetObject(Vector3 referencesPosition)
    {
        if(objectPool1.Count > 0)
        {
            GameObject tmp = objectPool1[0];
            objectPool1.Remove(tmp);
            tmp.transform.position = referencesPosition;
            tmp.SetActive(true);
            print("gaaa");
        }
        else
        {
            print("no hay objetos en el pool");
        }
    }
    public void SetObject(GameObject obj)
    {
        obj.SetActive(false);
        objectPool1.Add(obj);
    }
}
