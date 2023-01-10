using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectLoader : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    
    private Vector3 screenBounds;
    public GameObject CubeNav;
 

    void Awake()
    {
        CubeNav = GameObject.Find("CubeNav");
        Invoke("SpawnNext", 2.25001f);
        Invoke ("DestroyThis", 4.5f);
     

        
    }
    void SpawnNext()
    {
        CubeNav = GameObject.Find("CubeNav");
        Renderer rend = CubeNav.GetComponent<Renderer>();
        Vector3 posU = rend.bounds.center;
        posU.y = -2f;
        // posU.x = posU.x - 0.5f;    !use this formula if the object's transform isn't centered!



        // GameObject NewObjectRight = Instantiate(ObjectToSpawn, CubeNav.transform.position + (CubeNav.transform.forward * 1f), CubeNav.transform.rotation);
        GameObject NewObjectRight = Instantiate(ObjectToSpawn, posU, transform.rotation);

        //GameObject NewObjectUp = Instantiate(ObjectToSpawn, CubeNav.transform.position + (CubeNav.transform.up * 1), CubeNav.transform.rotation);

        //RB = Block.GetComponent<Rigidbody>();
        // RB.velocity = new Vector3(0, 0, 0);

    }

    void DestroyThis()
    {

        GameObject.Destroy(ObjectToSpawn);
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
      

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
