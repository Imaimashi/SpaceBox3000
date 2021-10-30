using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUpTime : MonoBehaviour
{
    public float scale;
    private float counter;

    public void Start()
    {
        counter = 0;
    }

    public void Work()
    {
        if (counter == 0)
        {
            Time.timeScale = 1.0f;
        }

        if (counter == 1)
        {
            Time.timeScale = scale;
        }
    }

    public void Accel()
    {
        if (counter == 1)
        {
            counter = 0;
        }

        else
        {
            counter = 1;
        }
    }
}