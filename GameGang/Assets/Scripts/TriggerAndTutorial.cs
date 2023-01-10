using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAndTutorial : MonoBehaviour
{
    int firstRun = 0;
    public GameObject Player;
    TutorialController TC;
    
    // Start is called before the first frame update
    void Start()
    {
        TC = GameObject.Find("Controller").GetComponent<TutorialController>();
        Player = GameObject.Find("left side");
        Vector3 sizeCalculated = Player.GetComponent<Renderer>().bounds.size;
        sizeCalculated.y = 3;
        sizeCalculated.x = 0.1f;
        transform.localScale = sizeCalculated;

        firstRun = PlayerPrefs.GetInt("savedFirstRun");


        if (firstRun == 0) // remember "==" for comparing, not "=" which assigns value
        {
            firstRun = 1;
            PlayerPrefs.SetInt("savedFirstRun", 1);

            
            
        }
        else
        {
            //Do lots of game save loading

            Destroy(gameObject.GetComponent<MeshFilter>());
            // Destroy(GameObject.Find("TutorialText"));
            transform.GetChild(0).gameObject.SetActive(false);
        }

    }
    void OnTriggerEnter(Collider other) 
        {
        if (firstRun == 0)
        {
            
           // StartCoroutine(Example());
            TC.Invoke("StartTutorial", 0f);
            Invoke("StopTime", 0.2f);
            Invoke("DestroyThis", 0f);
            
           
            
            
            
            
        }
            }
    void StopTime()
    {

        Time.timeScale = 0f;
        
    }
    public void DestroyThis()
    {
        Destroy(gameObject);
    }
    
   
 
}
   

    

