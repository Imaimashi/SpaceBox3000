using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempC : MonoBehaviour
{
    public Text Tl;
    public float T;
    public InputField TargetField;

    public void Temp()
    {
        Tl = TargetField.textComponent;
        T = float.Parse(Tl.text);
    }
}