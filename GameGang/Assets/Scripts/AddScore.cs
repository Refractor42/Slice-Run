using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    public Score ScoreScript;
    //public PointsAnim pa;
    TextMeshProUGUI EndScoreText;
    public GameObject Player;
    public GameObject ObjectToSpawn;
    

    public string AddPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        
        //pa = GameObject.Find("PointsMover").GetComponent<PointsAnim>();
        //Vector3 sizeCalculated = Player.GetComponent<Renderer>().bounds.size;
        //   sizeCalculated.y = 1;
        //  sizeCalculated.x = 1;
        // transform.localScale = sizeCalculated;

        ScoreScript = GameObject.FindWithTag("AddScore").GetComponent<Score>();
    }

    private void OnTriggerExit(Collider other)
    {
       
            Debug.Log("Adding Score...");
          
            ScoreScript.EndScore = ScoreScript.EndScore + 100;
        ScoreScript.theScore = ScoreScript.theScore + 100;
          //  ScoreScript.EndScoreText.text = ScoreScript.EndScore.ToString(); //this line doesnt compile
        
            GameObject NewObjectRight = Instantiate(ObjectToSpawn);




            

              Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
