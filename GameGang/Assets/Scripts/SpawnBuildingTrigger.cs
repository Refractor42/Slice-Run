using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuildingTrigger : MonoBehaviour
{
    GameObject Buildings;
    GameObject BuildingsL;
    EnvironmentLoaderRight ENLR;
    EnvironmentLoaderLeft ENLL;
    // Start is called before the first frame update
    void Start()
    {
        Buildings = GameObject.FindGameObjectWithTag("RightBuildings");
        BuildingsL = GameObject.FindGameObjectWithTag("LeftBuildings");
        ENLR = Buildings.GetComponent<EnvironmentLoaderRight>();
        ENLL = BuildingsL.GetComponent<EnvironmentLoaderLeft>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Invoke("DestroyThis", 0.1f);
        //pa.Invoke("StartAnim", 0f);
        ENLR.Invoke("SpawnNext", 0f);
        ENLL.Invoke("SpawnNext", 0f);
        
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyThis()
    {
        Destroy(this);
    }
}
