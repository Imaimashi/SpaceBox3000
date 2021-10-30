using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpTime : MonoBehaviour
{
    public float scale;
    public float timer;

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            timer = scale;
        }
        else
        {
            timer = 1.0f;
        }

        if (Input.GetKey(KeyCode.Z) && Time.timeScale != 0)
        {
            Time.timeScale = timer;
        }
    }
}
