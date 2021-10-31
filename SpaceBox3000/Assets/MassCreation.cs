using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassCreation : MonoBehaviour
{
    public Text Massl;
    public float Mass;
    public InputField TargetField;

    public void Masspos()
    {
        Massl = TargetField.textComponent;
        Mass = float.Parse (Massl.text);
    }
}