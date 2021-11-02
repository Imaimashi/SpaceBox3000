using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeC : MonoBehaviour
{
    public Text Al;
    public float A;
    public InputField TargetField;

    public void Age()
    {
        Al = TargetField.textComponent;
        A = float.Parse(Al.text);
    }
}