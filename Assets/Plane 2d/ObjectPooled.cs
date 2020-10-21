using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooled : MonoBehaviour
{
    public static ObjectPooled sharedInstance;
    [SerializeField] GameObject prefab;
    public List<GameObject> listObject = new List<GameObject>();
    public int amountToPool;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            var obj = Instantiate(prefab);
            listObject.Add(obj);
            obj.SetActive(false);
        }
    }

    public GameObject GetPooled(){
        for (int i = 0; i < listObject.Count; i++)
            if(!listObject[i].activeInHierarchy)
                return listObject[i];

        return null;
    }
}
