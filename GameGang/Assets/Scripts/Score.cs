using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreToRemove;
    public float RemovePoints;
    public int EndScore;
   public TextMeshProUGUI EndScoreText;
    public float theScore = 1;
    //public GameOver gameover;
    public UIControls UICTRLS;
    public float ScoreToAdd;
    public bool i = false;
    int b = 0;
    // Start is called before the first frame update
    void Start()
    {
        EndScoreText = GameObject.FindGameObjectWithTag("EndScore").GetComponent<TextMeshProUGUI>();
    }
    private void FixedUpdate()
    {
        if (theScore > 0)
        {
            ScoreToRemove = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
            RemovePoints = -1;
            theScore = theScore + RemovePoints;
            ScoreToRemove.text = theScore.ToString();
        }
        if (theScore <= 0)
        {
           
            
            //StartCoroutine(UICTRLS.InvokeGameOver()); 
            
            if (i == false)
            {
                Debug.Log("GameOver");
                UICTRLS.Invoke("ShowRevive", 0f);
                i = true;
                
            }
            else
            {
                UICTRLS.i = 0;
                StartCoroutine(UICTRLS.InvokeGameOver());
            }
            

        }
       
    }

    public void ReviveScore()
    {

        theScore = 1000;

    }


}
