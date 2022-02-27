using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLaunch : MonoBehaviour
{
    public float fireTime = 1f;
    int i = 0;
    float j = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Launch", fireTime, fireTime);
    }

    void Launch()
    {
        GameObject obj = NewObjectPooler.instance.getPooledObject();

        if(obj == null)
        {
            return;
        }

        j = Random.Range(-1f, 1f);
        obj.transform.position = new Vector3(j, transform.position.y, transform.position.z);
        obj.transform.rotation = transform.rotation;
        StartCoroutine(Wait());
        //obj.SetActive(true);
        /*if(i <= 30)
        {
            i++;
        }
        else
        {
            i = 0;
        }*/

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.1f);
            obj.SetActive(true);
        }
    }
}
