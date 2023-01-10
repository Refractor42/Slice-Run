using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LeftObjectLoader : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public float respawnTime;
    private Vector3 screenBounds;
    public GameObject CubeNav;
    public GameObject WallSpawn;
    public GameObject LnodeSpawn;
    public GameObject RnodeSpawn;
    public bool currentObstacle;
    GameObject MiddleBlock;
    Renderer rend;
    Vector3 posL;
    GameObject NewObjectRight;

    //  public Rigidbody RB;


    void Awake()
    {
        CubeNav = GameObject.Find("CubeNav");
        
        Invoke("SpawnNext", 2.25001f);
        Invoke("DestroyThis", 6.5f);

    }
    void SpawnNext()
    {
        
        rend = CubeNav.GetComponent<Renderer>();
        posL = rend.bounds.min;
       // posL.z = posL.z - 0.5f;     //use this formula if the object's transform isn't centered!
         posL.x = posL.x + 0.5f;
        posL.z = posL.z - 0.01f;
        Vector3 bos = posL;
        Vector3 tos = posL;
        //posL.y = posL.y + 1.63f;
        posL.y = 1.5f;   //was -2f

        bos.x = posL.x;
        bos.y = 1f;  //was -2f
        bos.z = -3.82f;

        tos.z = -2;

        // GameObject NewObjectRight = Instantiate(ObjectToSpawn, CubeNav.transform.position + (CubeNav.transform.forward * 1f), CubeNav.transform.rotation);
        NewObjectRight = Instantiate(ObjectToSpawn, posL, transform.rotation); //CubeNav
        GameObject Wall = Instantiate(WallSpawn, tos, transform.rotation);
        GameObject LeftNode = Instantiate(LnodeSpawn, posL, transform.rotation);
        GameObject RightNode = Instantiate(RnodeSpawn, bos, transform.rotation);
        LeftNode.GetComponent<SetPosition>().Parent = NewObjectRight; // this ramp(the left one) is the object on which's position the Right Node (of this pair of nodes) is going to spawn on(i accidentally switched the names of the nodes)

        // RB = ObjectToSpawn.GetComponent<Rigidbody>();
        // RB.velocity = new Vector3(0, 0, 0);
        MiddleBlock = GameObject.FindWithTag("MiddleBlock");
    }
         void FixedUpdate()
         {
        if (currentObstacle == false)
        {
            posL.z = MiddleBlock.GetComponent<Renderer>().bounds.max.z;
            NewObjectRight.transform.position = posL;
        }
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
