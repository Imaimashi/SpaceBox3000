using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject[] objects;
    private int hasobj;

    void Start()
    {
        hasobj = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.C) && hasobj != 1)
        {
            StartCoroutine(instobj());
            hasobj = 1;
        }
    }

    IEnumerator instobj()
    {
        Instantiate(objects[2], new Vector3(0, 0, 0), Quaternion.identity);
        yield return new WaitForSeconds(2.0f);
        hasobj = 0;
    }
}