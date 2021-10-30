using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassCreation : MonoBehaviour
{
    private Text myText;
    public static string Massl;
    public float Mass;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    public void Masspos()
    {
        Massl = myText.text.ToString();
        Mass = float.Parse(Massl);
    }
}