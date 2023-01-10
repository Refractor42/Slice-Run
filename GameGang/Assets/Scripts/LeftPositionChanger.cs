using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPositionChanger : MonoBehaviour
{
    public Renderer rend;
 
    
    public GameObject LeftParticle;


    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponentInParent<MeshRenderer>();
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 side = rend.bounds.min;
       
        Vector3 posL = LeftParticle.transform.position;
        posL.z = side.z;
        LeftParticle.transform.position = posL;

      
    }
}
