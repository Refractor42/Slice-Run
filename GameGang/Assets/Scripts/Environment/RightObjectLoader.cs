using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RightObjectLoader : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public float respawnTime;
    private Vector3 screenBounds;
    public GameObject CubeNav;
    public GameObject WallSpawn;
    public GameObject LnodeSpawn;
    public GameObject RnodeSpawn;
    public GameObject MidWallSpawn;
    public GameObject MidBlock;
    public bool currentObstacle;
    GameObject MiddleBlock;
    Vector3 posR;
    Renderer rend;
    GameObject NewObjectRight;

    // public Rigidbody RB;


    void Awake()
    {
        CubeNav = GameObject.Find("CubeNav");

      
        
        Invoke("SpawnNext", 2.25001f);
        Invoke("DestroyThis", 6.5f);
        

    }
    void SpawnNext()
    {
        
        rend = CubeNav.GetComponent<Renderer>();
        posR = rend.bounds.max;
        Vector3 bos = posR;
        Vector3 tos = posR;
        // posR.z = posR.z + 0.5f; // use this formula if the object's transform isn't centered!
        posR.x = posR.x - 0.5f;
        posR.y = 1.5f;   //was -2f
        posR.z = posR.z + 0.01f;

        bos.x = posR.x;
        bos.y = 1f;    //was -2f
        bos.z = 3.82f;

        tos.z = 2;




        // GameObject NewObjectRight = Instantiate(ObjectToSpawn, CubeNav.transform.position + (CubeNav.transform.forward * 1f), CubeNav.transform.rotation);
        GameObject CentWall = Instantiate(MidWallSpawn, CubeNav.transform.position, transform.rotation);
        Debug.Log("InstantiatedMidWall");
        NewObjectRight = Instantiate(ObjectToSpawn, posR, transform.rotation); //CubeNav
        GameObject Wall = Instantiate(WallSpawn, tos, transform.rotation);
        MiddleBlock = Instantiate(MidBlock, CubeNav.transform.position, transform.rotation);
        GameObject LeftNode = Instantiate(LnodeSpawn, posR, transform.rotation);
        
        GameObject RightNode = Instantiate(RnodeSpawn, bos, transform.rotation);
        LeftNode.GetComponent<SetPosition>().Parent = NewObjectRight;      //this ramp(the right one) is the object on which's position the Left Node(of this pair of nodes) is going to spawn on(i accidentally switched the names of the nodes)

     
        //GameObject NewObjectLeft = Instantiate(ObjectToSpawn, CubeNav.transform.position + (CubeNav.transform.forward * -1f), CubeNav.transform.rotation);
        //   RB = ObjectToSpawn.GetComponent<Rigidbody>();
        //   RB.velocity = new Vector3(0, 0, 0);


    }
    void FixedUpdate()
       {
        if (currentObstacle == false)
        {
            posR.z = MiddleBlock.GetComponent<Renderer>().bounds.max.z;
            NewObjectRight.transform.position = posR;
        }
       }
   
    void DestroyThis()
    {

        GameObject.Destroy(ObjectToSpawn);
        //GameObject.Destroy(MidWallSpawn);
        

    }
    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    
}
