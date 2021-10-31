using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XCreation : MonoBehaviour
{
    public Text Xl;
    public float X;
    public InputField TargetField;

    public void Xpos()
    {
        Xl = TargetField.textComponent;
        X = float.Parse(Xl.text);
    }
}
