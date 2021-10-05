using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveB : MonoBehaviour
{
    public Vector3 Force;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(Force);
    }
}
