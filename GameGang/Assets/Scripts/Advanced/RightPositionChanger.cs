using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPositionChanger : MonoBehaviour
{
    public Renderer rend;

    public GameObject RightParticle;
   

    
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponentInParent<MeshRenderer>();
       
    }
    // Update is called once per frame
  void Update()
    {
        Vector3 side = rend.bounds.max;
        Vector3 posR =  RightParticle.transform.position;
        posR.z = side.z;
        RightParticle.transform.position = posR;

        
       
        
    }
}
