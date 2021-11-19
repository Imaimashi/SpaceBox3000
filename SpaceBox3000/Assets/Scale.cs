using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public float Scope = 5000;
    public float Count = 5000;
    public Text scaleText;

    void Start()
    {
        scaleText.text = Scope.ToString();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Count >= 0)
            {
                Scope += 50;
                Count += 50;
                scaleText.text = Mathf.Round(Scope).ToString();
            }
            else
            {
                Count += 50;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Scope < 0)
            {
                Count -= 50;
            }
            else
            {
                Scope -= 50;
                Count -= 50;
                scaleText.text = Mathf.Round(Scope).ToString();
            }
        }

        if (Scope < 0)
        {
            Scope = 0;
            scaleText.text = Mathf.Round(Scope).ToString();
        }
    }
}
