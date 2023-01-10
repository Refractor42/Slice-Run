using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldMovement : MonoBehaviour
{
   // public GameObject player;
   // public GameObject Center;
   // int current = 1;
    public float speed;
  //  float WPradius = 1;
    public float ForwardSpeed;
    Rigidbody rb;
    Vector3 movement;
    public float IncSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
         rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        movement = new Vector3(SimpleInput.GetAxis("jump"), SimpleInput.GetAxis("Guz"), SimpleInput.GetAxis("Horizontal"));

        if (SimpleInput.GetAxis("Horizontal") > 0 || SimpleInput.GetAxis("Horizontal") < 0)
        {
            if (speed < 6)
                {
                speed = speed + IncSpeed;
            }
            else
            {
                speed = 6f;
            }
        } 
        else 
        {
            speed = 1;
        }
    //    Vector3 pos = transform.position;
        
      //  transform.position = pos;
       
     //   rb.velocity = transform.forward * ForwardSpeed;
    }
      void FixedUpdate()
    {
        ForwardSpeed += 5 * Time.deltaTime / 750;
        rb.velocity = transform.forward * ForwardSpeed;
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
    // Update is called once per frame

}
