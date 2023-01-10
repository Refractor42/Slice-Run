using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChildActive : MonoBehaviour
{
    public bool calledOnce = false;
    public GameObject Child;
    // Start is called before the first frame update
    void Start()
    {
        
        
        gameObject.transform.DetachChildren();
        Child.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        /*   if (calledOnce == false)
           {
               calledOnce = true;
               Invoke("DestroyWall", 0f);
           }*/
        /*  if (i == true)
          {

          }*/
        Debug.Log("Spawning Wall..."); //this proves the code is being called twice
        Invoke("DestroyWall", 0f);
        Child.SetActive(true);
       // 
    }
    public void DestroyWall()
    {
        
            gameObject.SetActive(false);
            Debug.Log("DisabledWall");
            calledOnce = true;
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
