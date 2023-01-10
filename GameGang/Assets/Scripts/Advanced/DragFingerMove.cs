using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerMove : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody rb;
    private Vector3 direction;
    private Vector3 pos;
    private float moveSpeed = 10f;
    private float a;
    private Vector3 vel;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        

    }

    // Update is called once per frame
    private void Update()
    {
       
        if (Input.touchCount > 0)
        {
            pos = transform.position;
            a = pos.x;
            pos.x = pos.z;
            pos.z = a;
            

            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
          //  touchPosition.y = 1.5f;
            
            direction = (touchPosition - pos);
            vel.z = direction.z* moveSpeed;
            rb.velocity = vel;
           

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector3.zero;
        }
    }
}

