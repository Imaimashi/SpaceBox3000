using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private int stop;

    void Start()
    {
        stop = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P) && stop == 0)
        {
            StartCoroutine(waiting());
        }
        if (Input.GetKey(KeyCode.P) && stop == 1)
        {
            Time.timeScale = 1.0f;
            stop = 0;
        }
    }

    IEnumerator waiting()
    {
        Time.timeScale = 0;
        yield return new WaitForSeconds(1.0f);
        stop = 1;
    }
}
