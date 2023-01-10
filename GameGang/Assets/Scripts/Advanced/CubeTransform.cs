using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{


    public GameObject CubeNav;
    public GameObject Player;
    public CubeTransform CubTR;
    float position;
   // public GameObject InstanceCoins;
  //  public bool Coins;
    

     public void CallMoveCube()
    {
      
            
           
            Invoke("MoveCube", 2.25f);
            
        
       
    }
  
    void MoveCube()
    {
        
            float rv = Random.value;
            if (rv < 0.33f)
            {
                position = -2.5f;
            }
            else if (rv > 0.33f && rv < 0.67f)
            {
                position = 0;
            }
            else if (rv > 0.67f)
            {

                position = 2.5f;

            }

        
      
        //CubeNav.transform.position = new Vector3(transform.position.x + transform.localScale.x - 1, transform.position.y, (transform.position.z - transform.position.z) + position);
        CubeNav.transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z - transform.position.z) + position);
        Invoke("SpawnCoins", 0.01f);
        
        
        Invoke("CallMoveCube", 0f);


    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CallMoveCube", 0f);
        CubTR = GameObject.FindWithTag("CubeNav").GetComponent<CubeTransform>();
    }

    /*public void SpawnCoins()
    {
        Vector3 pos = transform.position;
        pos.y = 1.5f;
        Quaternion quat = transform.rotation;
        quat.y = 0;
        if (Coins == true) //if it still glitches just check if the z position has changed and THEN spawn the coins.
        {
            GameObject Coinses = Instantiate(InstanceCoins, pos, quat); 
        }
    }
    */
    // Update is called once per frame
    void Update()
    {
        
            Player = GameObject.FindWithTag("Player");
            Vector3 sizeCalculated = Player.GetComponent<Renderer>().bounds.size;
            sizeCalculated.y = 1;
            sizeCalculated.x = 1;
            transform.localScale = sizeCalculated;
        
    }
}
