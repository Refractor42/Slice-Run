using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoverUp : MonoBehaviour
{
    public float ForwardSpeed;
    public float maxPos;
    public DragObject DO;
    public float currentPos;
    private bool execute = false;
    public Coroutine spawnCoroutine;
    public bool notGlitched = false;
    // public float WaitTime;


    int P;
   // public float timeToMoveUp = 0.625f;
    // Start is called before the first frame update
    /* void Start()
     {
         P = 1;
         StartCoroutine(Example());
     }

     IEnumerator Example()
     {
         yield return new WaitForSecondsRealtime(timeToMoveUp);

         P = 0;
     }
     // Update is called once per frame
     void FixedUpdate()
     {
         if (P >= 1)
         {
             transform.position += new Vector3(0, 0.1f , 0);
         }

     }
     void Stop()
     {
         P = 0;
     } 
   */

    private void Start()
    {
        
        StartCoroutine(WaitToSync());
        DO = GameObject.FindWithTag("Player").GetComponent<DragObject>();
        
    }

    IEnumerator WaitToSync()
    {
        yield return new WaitForSeconds(0.1f);

      



        
        Execute();
       
       
    }
   
    private void Execute()
    {
      execute = true;
    }
    void Update()
    {
        if (execute == true)
        {
            currentPos = transform.position.y;
            if (currentPos <= maxPos)
            {
                ForwardSpeed = DO.ForwardSpeed;
                transform.Translate(Vector3.up * Time.deltaTime * ForwardSpeed * 2, Space.World);

            }
            else if(notGlitched == true)
            {
                this.enabled = false;
            }
        }
    }
}
