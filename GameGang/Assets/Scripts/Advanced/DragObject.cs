using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public float ForwardSpeed;
    Rigidbody rb;
    public float speed = 0.1F;
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.z * speed, 0);
        }
    }
    void FixedUpdate()
    {
        //ForwardSpeed += 5 * Time.deltaTime / 750;
        ForwardSpeed += 0.001f;
        rb.velocity = transform.forward * ForwardSpeed;
        if(Input.GetKey(KeyCode.Space))
        {
            rb.velocity = rb.velocity + transform.up * ForwardSpeed;
        }
        else
        {
            rb.velocity = rb.velocity - transform.up * 7.5f;
        }
    }
     void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
}
