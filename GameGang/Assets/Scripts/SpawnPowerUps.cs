using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour
{
    //public GameObject SizeChanger;
    public GameObject PowerUpToSpawn;
    public float timeToSpawn;
    public float RandomRangeLow;
    public float RandomRangeHigh;
    public bool isItRare;
    public bool isItInAir;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PowerUps", timeToSpawn);

    }
    public void PowerUps() {
        if (isItRare == true)
        {
           
            GameObject NewObjectRight = Instantiate(PowerUpToSpawn, gameObject.transform.position, PowerUpToSpawn.transform.rotation);
            GameObject.Find("CubeNavigacion").GetComponent<CubeTransform>().Invoke("MoveCube", 0f);
        }
        if (isItInAir == true)
        {
            GameObject NewObjectRight = Instantiate(PowerUpToSpawn, gameObject.transform.position, PowerUpToSpawn.transform.rotation);
            GameObject.Find("CubeNavigacion").GetComponent<CubeTransform>().Invoke("MoveCube", 0f);
        }
        Invoke("PowerUps", Random.Range(RandomRangeLow, RandomRangeHigh));
        }
    // Update is called once per frame
    public void IntenseMoney()
    {
        if (isItRare == false)
        {
            RandomRangeLow = 0.2f;
            RandomRangeHigh = 0.2f;
            timeToSpawn = 0;
        }
        else
        {
            RandomRangeLow = 3f;
            RandomRangeHigh = 15f;
            timeToSpawn = 60f;
        }
    }
    public void NormalMoney()
    {
        if (isItRare == true)
        {
            RandomRangeHigh = 15f;
            RandomRangeLow = 3f;
            timeToSpawn = 60f;
        }
      
    }
    void Update()
    {
        
    }
}
