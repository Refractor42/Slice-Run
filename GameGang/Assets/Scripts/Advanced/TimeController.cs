using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("StopTime", 1f);
        Time.timeScale = 0;
    }

    void StopTime()
    {

        Time.timeScale = 0;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
   public void StartTime()
    {
        
        Time.timeScale = 1;

    }
    public void QuitApp()
    {

        Application.Quit();

    }
}
