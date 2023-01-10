using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject Frame1;
    public GameObject ArrowsHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        Frame1 = GameObject.Find("Frame1");
        ArrowsHorizontal = GameObject.Find("ArrowsHorizontal");
        Frame1.SetActive(false);

    }

    public void StartTutorial()
    {

        Frame1.SetActive(true);
        ArrowsHorizontal.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
