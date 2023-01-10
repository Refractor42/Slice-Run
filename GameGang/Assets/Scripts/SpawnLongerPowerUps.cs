using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLongerPowerUps : MonoBehaviour
{
    //public GameObject SizeChanger;
    public GameObject LongerPowerUpToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PowerUps", 60f);

    }
    public void PowerUps()
    {
        GameObject NewObjectRight = Instantiate(LongerPowerUpToSpawn, gameObject.transform.position, LongerPowerUpToSpawn.transform.rotation);
        GameObject.Find("CubeNavigacion").GetComponent<CubeTransform>().Invoke("MoveCube", 0f);
        Invoke("PowerUps", Random.Range(15f, 30f));
    }
    // Update is called once per frame
    void Update()
    {

    }
}