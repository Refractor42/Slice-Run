using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unparent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Invoke("RemoveParent", 1f);
        
    }

    public void RemoveParent()
    {
        transform.parent = null;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
