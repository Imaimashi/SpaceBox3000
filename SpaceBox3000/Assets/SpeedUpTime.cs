using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpTime : MonoBehaviour
{
    private float _movementSpeed = 1f;

    public float scaleOfTime = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            transform.Translate(new Vector3(_movementSpeed, 0, 0) * Time.deltaTime);

            if (transform.position.x > 10f || transform.position.x < -10f)
            {
                _movementSpeed = -_movementSpeed;
            }

            Time.timeScale = scaleOfTime;
        }
    }
}
