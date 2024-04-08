using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class ObjectPolling : MonoBehaviour
{
    public List<GameObject> objectPool;
    public PoolObjectBullet objecPrefab;
    public void GetObject(Vector3 references)
    {
        GameObject tmp;
        if (objectPool.Count > 0)
        {
            tmp = objectPool[0];
            objectPool.Remove(tmp);
            tmp.transform.position = references; 
            tmp.GetComponent<PoolObjectBullet>().SetRefencesPolling(this);    
            tmp.SetActive(true);
        }
        else
        {
            tmp = Instantiate(objecPrefab.gameObject,references,Quaternion.identity,transform);
            tmp.GetComponent<PoolObjectBullet>().SetRefencesPolling(this);
            tmp.SetActive(true);
        }
    }
    public void SetObject(GameObject obj)
    {
        obj.SetActive(false);
        objectPool.Add(obj);
    }

}
