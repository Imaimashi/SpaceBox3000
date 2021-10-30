using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XCreation : MonoBehaviour
{
    private Text myText;
    public static string Xl;
    public float X;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    public void Xpos()
    {
        Xl = myText.text.ToString();
        X = float.Parse(Xl);
    }
}
