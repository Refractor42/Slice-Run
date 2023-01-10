using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentLoaderRight : MonoBehaviour
{
    private float RandomValue;
    public GameObject Buildings;
    public GameObject Buildings1;
    public GameObject Buildings2;
    public GameObject Buildings3;
    public GameObject ChosenBuildings;
    public GameObject ObjectToSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        RandomValue = Random.value;
        if (RandomValue < 0.33f)
        {
            ChosenBuildings = Buildings1;
        }
        else if(RandomValue > 0.33f && RandomValue < 0.66f)
        {
            ChosenBuildings = Buildings2;
        }
        else
        {
            ChosenBuildings = Buildings3;
        }

        //Invoke("SpawnNext", 6.00001f);
        //Invoke("DestroyThis", 50f);

        

        ObjectToSpawn = ChosenBuildings;
    }

    void SpawnNext()
    {
        Buildings = GameObject.FindGameObjectWithTag("RightBuildings");
        Renderer rend = Buildings.GetComponentInChildren<Renderer>();
        Vector3 posL = rend.bounds.min;
        // posL.z = posL.z - 0.5f;     //use this formula if the object's transform isn't centered!
        posL.x = posL.x - 30f;
        posL.z = 13f;
        posL.y = 0;


        GameObject NewObjectRight = Instantiate(ObjectToSpawn, posL, transform.rotation); //LastBuilding

        Buildings.tag = "Texture";
        
        Invoke("DestroyThis", 70f);


    }
    void DestroyThis()
    {

        GameObject.Destroy(ObjectToSpawn);

    }
}

