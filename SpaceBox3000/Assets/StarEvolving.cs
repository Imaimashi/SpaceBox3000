using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarEvolving : MonoBehaviour
{

    public float time;
    public float stat;
    public float Mass;
    public float scalex;
    public float scaley;
    public float scalez;
    public float X;
    public float Z;
    private int counter;
    public GameObject SN;
    public Material WD;
    public Material SG;
    public Material BD;
    public Material BG;
    public Material NS;
    public Material BH;

    void Start()
    {
        time = 180;
        stat = 180;
        Mass = GetComponent<Rigidbody>().mass;
        scalex = transform.localScale.x;
        scaley = transform.localScale.y;
        scalez = transform.localScale.z;
        counter = 0;
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= (2*stat)/3 && time > stat/3 && Mass < 5)
        {
            GetComponent<Renderer>().material = WD;
            transform.localScale = new Vector3(scalex/2, scaley/2, scalez/2);
        }
        if(time < 0 && Mass < 5)
        {
            GetComponent<Renderer>().material = BD;
            transform.localScale = new Vector3(scalex / 8, scaley / 8, scalez / 8);
        }

        if (time <= (2*stat)/3 && time > stat/3 && Mass >= 5 && Mass < 50)
        {
            GetComponent<Renderer>().material = SG;
            transform.localScale = new Vector3(scalex * 2, scaley * 2, scalez * 2);
        }
        if(time <= stat/3 && time > 0 && Mass >= 5 && Mass < 50)
        {
            GetComponent<Renderer>().material = WD;
            transform.localScale = new Vector3(scalex / 2, scaley / 2, scalez / 2);
        }
        if (time < 0 && Mass >= 5 && Mass < 50)
        {
            GetComponent<Renderer>().material = BD;
            transform.localScale = new Vector3(scalex / 8, scaley / 8, scalez / 8);
        }

        if(time <= (2 * stat) / 3 && time > stat / 3 && Mass >= 50 && Mass < 500)
        {
            GetComponent<Renderer>().material = BG;
            transform.localScale = new Vector3(scalex * 8, scaley * 8, scalez * 8);
        }
        if (time <= stat / 3 && time > 0 && Mass >= 50 && Mass < 500)
        {
            GetComponent<Renderer>().material = SG;
            transform.localScale = new Vector3(scalex * 4, scaley * 4, scalez * 4);
        }
        if (time < 0 && Mass >= 50 && Mass < 500)
        {
            X = transform.position.x;
            Z = transform.position.z;

            if (counter != 1 && time >= -2)
            {
                counter = 1;
                
                Instantiate(SN, new Vector3(X, 0, Z), Quaternion.identity);
            }

            GetComponent<Renderer>().material = NS;
            transform.localScale = new Vector3(scalex / 4, scaley / 4, scalez / 4);
        }

        if (time <= (2 * stat) / 3 && time > stat / 3 && Mass >= 500)
        {
            GetComponent<Renderer>().material = BG;
            transform.localScale = new Vector3(scalex * 8, scaley * 8, scalez * 8);
        }
        if (time < 0 && Mass >= 500)
        {
            X = transform.position.x;
            Z = transform.position.z;

            if (counter != 1 && time >= -2)
            {
                counter = 1;

                Instantiate(SN, new Vector3(X, 0, Z), Quaternion.identity);
            }

            GetComponent<Renderer>().material = BH;
            transform.localScale = new Vector3(scalex / 4, scaley / 4, scalez / 4);
        }
    }
}
