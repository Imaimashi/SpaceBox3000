using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Rigidbody newsph;
    private int hasobj;
    public float X;
    public float Z;
    public float Scale;
    public float Mass;

    void Awake()
    {
        
    }

    void Start()
    {
        hasobj = 0;
    }

    void Update()
    {
        newsph.transform.localScale = new Vector3(Scale, Scale, Scale);
        newsph.mass = Mass;
        if (Input.GetKey(KeyCode.C) && hasobj != 1)
        {
            StartCoroutine(instobj());
            hasobj = 1;
        }
    }

    IEnumerator instobj()
    {
        Instantiate(newsph, new Vector3(X, 0, Z), Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        hasobj = 0;
    }
}
