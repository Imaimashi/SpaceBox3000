using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour
{
    public Rigidbody newsph;
    private int hasobj;
    private float X;
    private float Z;
    private float Scale;
    private float Mass;

    void Start()
    {
        hasobj = 0;

        GameObject go = GameObject.Find("xPos");
        XCreation xcreation = go.GetComponent<XCreation>();
        X = xcreation.X;

        GameObject.Find("zPos");
        ZCreation zcreation = go.GetComponent<ZCreation>();
        Z = zcreation.Z;

        GameObject.Find("Scale");
        ScaleCreation scalecreation = go.GetComponent<ScaleCreation>();
        Scale = scalecreation.Scale;

        GameObject.Find("Mass");
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