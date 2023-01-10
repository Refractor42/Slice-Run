using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class MaxSpeed : MonoBehaviour
{
    public float maxSpeed = 10f;
    public Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Trying to Limit Speed
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 200), "rigidbody velocity: " + rb.velocity);
    }
}