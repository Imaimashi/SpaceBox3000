using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody newsph;
    public float Scale;
    public float Mass;

    void Start()
    {
        newsph.transform.localScale = new Vector3(Scale, Scale, Scale);
        newsph = GetComponent<Rigidbody>();
        newsph.mass = Mass;
    }
}
