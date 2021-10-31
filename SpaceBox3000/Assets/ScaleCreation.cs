using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleCreation : MonoBehaviour
{
    public Text Scalel;
    public float Scale;
    public InputField TargetField;

    public void Scalepos()
    {
        Scalel = TargetField.textComponent;
        Scale = float.Parse(Scalel.text);
    }
}