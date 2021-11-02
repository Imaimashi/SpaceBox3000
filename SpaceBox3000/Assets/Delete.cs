using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public float counter;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (counter == 0)
            {
                counter = 1;
            }
            else
            {
                counter = 0;
            }
        }
    }

    private void OnMouseDown()
    {
        if (counter == 1)
        {
            Destroy(gameObject);
        }
    }
}
