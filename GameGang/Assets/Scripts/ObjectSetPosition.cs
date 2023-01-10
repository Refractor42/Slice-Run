using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetPosUp()
    {
        Vector3 pos = gameObject.transform.position;
        pos.y = 5;
        gameObject.transform.position = pos;
    }
    public void SetPosDown()
    {
        Vector3 pos = gameObject.transform.position;
        pos.y = 1.5f;
        gameObject.transform.position = pos;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
