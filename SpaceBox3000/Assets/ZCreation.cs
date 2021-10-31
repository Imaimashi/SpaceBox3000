using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZCreation : MonoBehaviour
{
    public Text Zl;
    public float Z;
    public InputField TargetField;

    public void Zpos()
    {
        Zl = TargetField.textComponent;
        Z = float.Parse(Zl.text);
    }
}