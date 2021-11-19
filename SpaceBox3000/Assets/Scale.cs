using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public float Scope = 5000;
    public Text scaleText;

    void Start()
    {
        scaleText.text = Scope.ToString();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Scope += 50;
            scaleText.text = Mathf.Round(Scope).ToString();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Scope -= 50;
            scaleText.text = Mathf.Round(Scope).ToString();
        }
    }
}
