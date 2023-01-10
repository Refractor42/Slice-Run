using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshCollider>().enabled = false;
        gameObject.GetComponent<MeshCollider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
