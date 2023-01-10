using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    Rigidbody rb;
    public float ForwardSpeed;
    public GameObject Player;
    public bool SlowDownForPlayer = true;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
        if (Player.transform.position.x - 7.5f > this.transform.position.x && Player.transform.position.x - 7.55f < this.transform.position.x) //wtoroto beshe 8.5
        {
            if (SlowDownForPlayer == true)
            {
                ForwardSpeed = Player.GetComponent<DragObject>().ForwardSpeed - 0.1f;
            }
          
        }
      
        else if (Player.transform.position.x - 7.55f > this.transform.position.x) 
        {
            if (SlowDownForPlayer == true)
            {
                ForwardSpeed = Player.GetComponent<DragObject>().ForwardSpeed - 1f;
            }
            else
            {
                
                ForwardSpeed = Player.GetComponent<DragObject>().ForwardSpeed;
            }
        }
        else if(Player.transform.position.x - 7.5f < this.transform.position.x)
        {
            ForwardSpeed = Player.GetComponent<DragObject>().ForwardSpeed + 1f;
        }
     
        else
        {
            
            ForwardSpeed = Player.GetComponent<DragObject>().ForwardSpeed;
        }
        rb.velocity = transform.forward * ForwardSpeed;
    }
}
