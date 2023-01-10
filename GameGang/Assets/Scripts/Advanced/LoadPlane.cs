using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LoadPlane : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public float respawnTime = 2.0f;
   
    
    public GameObject SCubeNav;
   
    // public Rigidbody RB;

   // public GameObject Block;

    void Awake()
    {
        SCubeNav = GameObject.Find("SCubeNav");
        


     
        Invoke("SpawnNext", 8f);
        Invoke("DestroyThis", 15f);


    }
    void SpawnNext()
    {
        SCubeNav = GameObject.Find("PlaneSpawnLocation");

        GameObject NewObject = Instantiate(ObjectToSpawn, SCubeNav.transform.position + (SCubeNav.transform.up * -0.5f), SCubeNav.transform.rotation);

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
