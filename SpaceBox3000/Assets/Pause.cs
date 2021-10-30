using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
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
            Time.timeScale = 0;
        }
    }

    public void Stop()
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