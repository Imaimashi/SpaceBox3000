using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateS : MonoBehaviour
{
    public Rigidbody newsph1;
    public Rigidbody newsph2;
    public Rigidbody newsph3;
    public Rigidbody newsph4;
    public Rigidbody newsph5;
    public Rigidbody newsph6;
    public Rigidbody newsph7;
    private int hasobj;
    public float X;
    public float Z;
    public float Scale;
    public float Mass;
    public float Temp;
    public float Age;

    void Start()
    {
        hasobj = 0;
    }

    public void Find1()
    {
        GameObject go = GameObject.Find("xPos");
        XCreation xcreation = go.GetComponent<XCreation>();
        X = xcreation.X;
    }

    public void Find2()
    {
        GameObject go = GameObject.Find("zPos");
        ZCreation zcreation = go.GetComponent<ZCreation>();
        Z = zcreation.Z;
    }

    public void Find3()
    {
        GameObject go = GameObject.Find("Scale");
        ScaleCreation scalecreation = go.GetComponent<ScaleCreation>();
        Scale = scalecreation.Scale;
    }

    public void Find4()
    {
        GameObject go = GameObject.Find("Mass");
        MassCreation masscreation = go.GetComponent<MassCreation>();
        Mass = masscreation.Mass;
    }

    public void Find5()
    {
        GameObject go = GameObject.Find("STemp");
        TempC temp = go.GetComponent<TempC>();
        Temp = temp.T;
    }

    public void Find6()
    {
        GameObject go = GameObject.Find("SAge");
        AgeC age = go.GetComponent<AgeC>();
        Age = age.A;
    }

    public void CreateSO()
    {
        if (Temp > 30000)
        {
            newsph1.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph1.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph1, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }

    public void CreateSB()
    {
        if (Temp > 10000 && Temp <= 30000)
        {
            newsph2.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph2.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph2, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }

    public void CreateSA()
    {
        if (Temp > 7400 && Temp <= 10000)
        {
            newsph3.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph3.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph3, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }

    public void CreateSF()
    {
        if (Temp > 6000 && Temp <= 7400)
        {
            newsph4.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph4.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph4, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }

    public void CreateSG()
    {
        if (Temp > 5000 && Temp <= 6000)
        {
            newsph5.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph5.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph5, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }

    public void CreateSK()
    {
        if (Temp > 3800 && Temp <= 5000)
        {
            newsph6.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph6.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph6, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }

    public void CreateSM()
    {
        if (Temp > 2499 && Temp <= 3800)
        {
            newsph7.transform.localScale = new Vector3(Scale, Scale, Scale);
            newsph7.mass = Mass;
            if (hasobj != 1)
            {
                StartCoroutine(instobj());
                hasobj = 1;

                IEnumerator instobj()
                {
                    Instantiate(newsph7, new Vector3(X, 0, Z), Quaternion.identity);
                    yield return new WaitForSeconds(1.0f);
                    hasobj = 0;
                }
            }
        }
    }
}
