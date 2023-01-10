using UnityEngine;
using System.Collections;
public class LockMovement : MonoBehaviour
{

    public KeyCode moveL;
    public KeyCode moveR;
    public float horizVel = 0; // Use this for initialization void Start () 

    // Update is called once per frarr void 
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, horizVel);
        if (Input.GetKeyDown(moveL))
        {
            horizVel = -5;
            StartCoroutine(stopSlide());
        }
        if (Input.GetKeyDown(moveR))
        {
            horizVel = 5;
            StartCoroutine(stopSlide());
        }
    }


    IEnumerator stopSlide()
    {

        yield return new WaitForSeconds(.5f);
        horizVel = 0;

    }
}