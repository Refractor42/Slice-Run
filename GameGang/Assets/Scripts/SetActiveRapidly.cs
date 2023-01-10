using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveRapidly : MonoBehaviour
{
    public GameObject Cutters;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetInactiveCutters()
    {

        Cutters.SetActive(false);

        Invoke("SetActiveCutters", 1f);
    }
    public void SetActiveCutters()
    {
        Cutters.SetActive(true);
        Invoke("SetInactiveCutters", 1f);
    }

}
