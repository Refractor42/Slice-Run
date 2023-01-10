using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCreator : MonoBehaviour
{
  
    public float ValueToSubtract;
    public float time;


    public GameObject BuildingToSpawn;
    public GameObject Building1;
    public GameObject Building2;
    public GameObject Building3;
    public Quaternion rot;
    public Vector3 pos;


    public void Spawn()
    {
        int RandomNumber = Random.Range(0, 99);
        if (RandomNumber <= 33f)
        {
            BuildingToSpawn = Building1;
        }
        else if (RandomNumber >33f && RandomNumber <= 66f)
        {
            BuildingToSpawn = Building2;
        }
        else if (RandomNumber > 66f)
        {
            BuildingToSpawn = Building3;
        }
        else
        {
            Debug.Log("Building not chosen");
        }
        rot.x = -1;
        Renderer rend = gameObject.GetComponentInChildren<Renderer>();
       
        pos = gameObject.transform.position;
        pos.y = 8.2f;
        pos.x = pos.x - 26.9f;
        pos.z = 0;
        Instantiate(BuildingToSpawn, pos, rot * Quaternion.Euler(90f, 0f, 0f));
    }
  

    void Start()
    {
        // Invoke("Spawn", 5f);
        Invoke("Spawn", time - ValueToSubtract);
    }

   
}
