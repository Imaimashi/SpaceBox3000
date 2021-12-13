using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public float Scope = 1000000;
    public float Count = 1000000;
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
                Scope = Scope*1001/1000;
                Count = Count*1001/1000;
                scaleText.text = Mathf.Round(Scope).ToString();
            }
            else
            {
                Count = Count*11/10;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Scope < 0)
            {
                Count = Count*1000/1001;
            }
            else
            {
                Scope = Scope*1000/1001;
                Count = Count*1000/1001;
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
