using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour
{
    public Rigidbody newsph;
    private int hasobj;
    public float X;
    public float Z;
    public float Scale;
    public float Mass;

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

    public void CreateObj()
    {
        newsph.transform.localScale = new Vector3(Scale, Scale, Scale);
        newsph.mass = Mass;
        if (hasobj != 1)
        {
            StartCoroutine(instobj());
            hasobj = 1;

            IEnumerator instobj()
            {
                Instantiate(newsph, new Vector3(X, 0, Z), Quaternion.identity);
                yield return new WaitForSeconds(1.0f);
                hasobj = 0;
            }
        }
    }
}