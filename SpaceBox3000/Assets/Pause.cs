using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public float timer;
    private bool ispause;

    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.P) && ispause == false)
        {
            ispause = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && ispause == true)
        {
            ispause = false;
        }
        if (ispause == true)
        {
            timer = 0;
        }
        else if (ispause == false)
        {
            timer = 1f;
        }
    }
}