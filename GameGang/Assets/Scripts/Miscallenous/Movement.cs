using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
    {
        Vector3 pos;
    
        float Speed;
    public Vector3 movement;
   
        public Rigidbody rb;
        public float IncreasingVelocity = 7.5f;
    float moveSpeed;
    public float ForwardSpeed = 5;
 

        // Start is called before the first frame update
        void Start()
        {
        rb = GetComponent<Rigidbody>();
        
    
        pos.y = 1.5f;
        }
        
     
       public void StopSpeed()
        {

            Speed = 0;
        Debug.Log("StopSpeed");

        }

        // Update is called once per frame
        void Update()
        {

       
        
  
        movement = new Vector3(SimpleInput.GetAxis("Jump"), SimpleInput.GetAxis("Vertical"), SimpleInput.GetAxis("Horizontal"));
        }
    private void FixedUpdate()
    {
       moveCharacter(movement);
        rb.velocity = transform.forward * ForwardSpeed;

    }
    void moveCharacter(Vector3 direction)
    {
        if (SimpleInput.GetAxis("Horizontal") != 0)
        {
            if (Speed < 10f)
            {
                Speed += IncreasingVelocity * Time.deltaTime;
            }
            else
            {
                Speed = 10f;
            }
        }
        rb.MovePosition(transform.position + (direction * Speed * Time.deltaTime));
       
    }
   

}

    
