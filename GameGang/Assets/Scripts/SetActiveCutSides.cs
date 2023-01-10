using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveCutSides : MonoBehaviour
{
    public GameObject CutSide1;
    public GameObject CutSide2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetActiveAgain()
    {
        CutSide1.SetActive(true);
        CutSide2.SetActive(true);
    }
}
