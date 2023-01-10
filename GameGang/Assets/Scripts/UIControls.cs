using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControls : MonoBehaviour
{
    public string ReviveShow = "PauseMenuShow";
    public string ReviveHide = "PauseMenuHide";
    public GameObject ReviveUI;
    public GameObject Hover;
    public GameObject PauseButton;
    public int i = 0;
    public int timetowait = 10;
    public GameOver GMVR;
    public Score ScoreScript;
    public GameObject[] text;


    public void ShowRevive()
    {
        PauseButton.SetActive(false);
        Hover.SetActive(true);

        ReviveUI.GetComponent<Animator>().Play(ReviveShow, 0, 0);
        StartCoroutine(InvokeGameOver());

    }
    public void HideRevive()
    {
        PauseButton.SetActive(true);
        Hover.SetActive(false);

        ReviveUI.GetComponent<Animator>().Play(ReviveHide, 0, 0);
        i = 1;
        timetowait = 0;
    }

    public void DecreaseTime()
    {
        timetowait = timetowait - 2;
    }
    public IEnumerator InvokeGameOver()
    {


        yield return new WaitForSeconds(timetowait);

        if (i == 1)
        {
            // i = 0;
//            Debug.Log("i = 1");
        }
        else
        {
           // Debug.Log("i = 0");
            GMVR.Invoke("GameOverScore", 0f);
        }
    }
    public void GameOverInvoke()
    {
        GMVR.Invoke("GameOverScore", 0f);
    }

    public void RemoveText()
    {
        foreach (GameObject go in text)
        {
            go.SetActive(false);
        }

    }
    private void Start()
    {
        text = GameObject.FindGameObjectsWithTag("Text");   
    }
}