using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{

    
    /*public float ForwardSpeedBefore; //Original Number
    public float Increase;           //Difference between original number and New Number
    public float PercentageIncrease; //The Increase in a Percentage
    public float DecimalPercentageIncrease;
    public float ForwardSpeed = 5;  //New Number */
    
    public GameObject TowerToSpawn;
    public Quaternion rot;
    public Vector3 pos;
    public GameObject lastSpawned;
    public GameObject Building1;
    public GameObject Building2;
    public GameObject Building3;
    public float distance;
    public float neededspace = 26.9f;
    public float number;

   // public GameObject[] Towers;
    
  
    public void SpawnBuildings()
    {

       

        for (int i = 0; i < (int)number; i++)
        {
            int RandomNumber = Random.Range(0, 99);
        if (RandomNumber <= 33f)
        {
           TowerToSpawn = Building1;
        }
        else if (RandomNumber > 33f && RandomNumber <= 66f)
        {
            TowerToSpawn = Building2;
        }
        else if (RandomNumber > 66f)
        {
            TowerToSpawn = Building3;
        }
        else
        {
            Debug.Log("Building not chosen");
        }
            rot.x = -1;
            pos.y = 8.2f;
            pos.x = lastSpawned.transform.position.x - 26.9f;
            GameObject BuildingToSpawn = lastSpawned = Instantiate(TowerToSpawn, pos, rot * Quaternion.Euler(90f, 0f, 0f));
        }
    }

    private void FixedUpdate()
    {
        CalculateNumber();
        SpawnBuildings();
    }

  
    public void CalculateNumber()
    {
        distance = lastSpawned.transform.position.x - gameObject.transform.position.x;
        number = distance / neededspace;

        number = Mathf.Round(number);

       
    }
}
