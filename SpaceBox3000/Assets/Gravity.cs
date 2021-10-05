using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private HashSet<Rigidbody> affectedBodies = new HashSet<Rigidbody>();
    private Rigidbody componentRigidbody;

    private void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Remove(other.attachedRigidbody);
        }
    }

    private void FixedUpdate()
    {
        foreach (Rigidbody body in affectedBodies)
        {
            Vector3 forceDirection = (transform.position - body.position).normalized;
            float distanceSqr = (transform.position - body.position).sqrMagnitude;
            float strength = 10 * componentRigidbody.mass * body.mass / distanceSqr;

            body.AddForce(forceDirection * strength);
        }
    }
}