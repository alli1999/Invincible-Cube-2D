using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewObjectPooler : MonoBehaviour
{

    public static NewObjectPooler instance;
    public GameObject pooledObject;
    public GameObject pooledObject1;
    public GameObject pooledObject2;

    public int pooledAmount = 20;
    public bool willGrow = true;

    public static string objectball;
    public static string objectdice;
    public static string objectmilk;

    public List<GameObject> pooledObjects;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        objectball = "";
        objectdice = "";
        objectmilk = "";

        pooledObjects = new List<GameObject>();
        for(int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            GameObject obj1 = (GameObject)Instantiate(pooledObject1);
            GameObject obj2 = (GameObject)Instantiate(pooledObject2);
            
            obj.SetActive(false);
            obj1.SetActive(false);
            obj2.SetActive(false);

            pooledObjects.Add(obj);
            pooledObjects.Add(obj1);
            pooledObjects.Add(obj2);
        }
    }

    public GameObject getPooledObject()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy && (pooledObjects[i].name == objectdice || pooledObjects[i].name == objectball || pooledObjects[i].name == objectmilk))
            {
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }

        return null;
    }
}
