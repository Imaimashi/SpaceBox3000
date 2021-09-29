using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] public float speed = 0; // скорость
  
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0); // вращение планеты
    }
}