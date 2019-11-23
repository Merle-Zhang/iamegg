using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unactive : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;

    void Start()
    {
        target2.SetActive(false);
    }


    void OnCollisionEnter(Collision theCollision)
    {

        //target1.SetActive(false);
        //target2.SetActive(true);
        if (theCollision.gameObject.name == "wok_01")
        {
            //Transform tf1 = target1.GetComponent<Transform>();
            //Transform tf2 = target2.GetComponent<Transform>();
            //tf2.position = tf1.position + Vector3.up * 10;
            target1.SetActive(false);
            target2.SetActive(true);
        }
    }
}
