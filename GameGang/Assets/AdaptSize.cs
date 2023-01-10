using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptSize : MonoBehaviour
{
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
         Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 sizeCalculated = Player.GetComponent<Renderer>().bounds.size;
        sizeCalculated.y = 1;
        sizeCalculated.x = 1;
        transform.localScale = sizeCalculated;
    }
}
