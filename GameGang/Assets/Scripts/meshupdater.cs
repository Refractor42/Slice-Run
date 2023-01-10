using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshupdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DoIt", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DoIt()
    {

        Destroy(gameObject.GetComponent<MeshCollider>());
       
        gameObject.AddComponent<MeshCollider>().convex = true; ;
        

        Invoke("DoIt", 0.1f);
    }
}
