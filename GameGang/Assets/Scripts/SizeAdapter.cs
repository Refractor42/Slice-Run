using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeAdapter : MonoBehaviour
{
    public GameObject ObjectGivingTransform;
    Vector3 pos;
    int i;
    Vector3 size;
    Quaternion rotation;
   // public bool isCubeNav;
   // public GameObject[] parts;

    private void Start()
    {
       /* if(isCubeNav == true)
        {
            
            ObjectGivingTransform = GameObject.FindWithTag("CubeNav");
            foreach(GameObject go in parts)
            {
                go.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
         // mad sus if this works
      //  gameObject.transform.parent = null;

       // gameObject.SetActive(false);

     /*   pos = ObjectGivingTransform.transform.position;
       // pos.x = pos.x - 1;
        pos.y = 1.5f;
        size.z = size.z / 2;
        size = ObjectGivingTransform.transform.localScale;
        */


    }

    /*private void OnTriggerEnter(Collider other) //FOR SOME REASON THEY DISAPPEAR WHEN YOU HIT THE COLLIDER!!!!
    {
        foreach (GameObject go in parts)
        {
            go.GetComponent<Rigidbody>().isKinematic = false;
        }
    }*/
    private void Update()
    {
        if ( i == 0 && ObjectGivingTransform == true)
            {
                gameObject.transform.parent = null;

                pos = ObjectGivingTransform.transform.position;
                // pos.x = pos.x - 1;
                pos.y = 1.87f;
                 
                size = ObjectGivingTransform.transform.localScale;
                size.z /= 10.3f;
            size.y = 0.5f;
            size.x = 1f;
            gameObject.transform.localScale = size;
                gameObject.transform.position = pos;
            i = 1;

            rotation.z = 0;
            rotation.y = 0;
            rotation.x = 0;
            gameObject.transform.rotation = rotation;
            }
    }
}
