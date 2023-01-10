using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartAdjustment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GameObject MC = GameObject.Find("Main Camera");
        CameraController CC = MC.GetComponent<CameraController>();
        
        Invoke("StartTime", 0f);
        CC.Invoke("DefaultView", 0f);
    }

    void StartTime()
    {

        Time.timeScale = 1;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
