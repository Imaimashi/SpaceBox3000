using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public GameObject tripod;
    public float speed;

    private void Start()
    {
        tripod = (GameObject)this.gameObject;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            tripod.transform.position += tripod.transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            tripod.transform.position -= tripod.transform.right * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            tripod.transform.position -= tripod.transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            tripod.transform.position += tripod.transform.right * speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            tripod.transform.position += tripod.transform.up * speed;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            tripod.transform.position -= tripod.transform.up * speed;
        }
    }
}
