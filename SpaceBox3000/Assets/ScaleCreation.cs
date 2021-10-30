using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleCreation : MonoBehaviour
{
    private Text myText;
    public static string Scalel;
    public float Scale;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    public void Scalepos()
    {
        Scalel = myText.text.ToString();
        Scale = float.Parse(Scalel);
    }
}