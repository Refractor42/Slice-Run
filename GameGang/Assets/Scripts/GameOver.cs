using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class GameOver : MonoBehaviour
{
    public string GameOverShow = "PauseMenuShow";
    public string GameOverHide = "PauseMenuHide";
    public GameObject GameOverUI;
    public GameObject Hover;
    public GameObject PauseButton;
    public GameObject ScoreText;
    public GameObject ReviveMenu;
    public void OnTriggerEnter(Collider other)
    {
        PauseButton.SetActive(false);
        Hover.SetActive(true);
        ScoreText.SetActive(false);
        GameOverUI.GetComponent<Animator>().Play(GameOverShow, 0, 0);

    }
    public void GameOverScore()
    {
        PauseButton.SetActive(false);
        Hover.SetActive(true);
        ScoreText.SetActive(false);
        GameOverUI.GetComponent<Animator>().Play(GameOverShow, 0, 0);
        ReviveMenu.SetActive(false);
      //  Debug.Log("Done");
      
    }

}
