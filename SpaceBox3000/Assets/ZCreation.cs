using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZCreation : MonoBehaviour
{
    private Text myText;
    public static string Zl;
    public float Z;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    public void Zpos()
    {
        Zl = myText.text.ToString();
        Z = float.Parse(Zl);
    }
}