using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneMovement : MonoBehaviour
{

    public GameObject[] waypoints;
    public GameObject player;
    public GameObject Center;
    int current = 1;
    public float speed;
    float WPradius = 1;
    public float ForwardSpeed;

    public void GoLeft()
    {
        if (current > 0)
        {
            current = current - 1;
            Debug.Log("CurrentLeft = " + current);
        }
    }
    public void GoRight()
    {
        if (current < 2)
        {
            current = current + 1;
            Debug.Log("CurrentRight = " + current);
        }
    }
    void Update()
    {
        //transform.position = Center.transform.position;
        Vector3 pos = transform.position;
        pos.z = Mathf.MoveTowards(transform.position.z, waypoints[current].transform.position.z, Time.deltaTime * speed);
        transform.position = pos;
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * ForwardSpeed;
    }
}

