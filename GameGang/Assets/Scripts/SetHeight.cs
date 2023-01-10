using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeight : MonoBehaviour
{
    public float Height = 1.8f;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()

    {
        pos = gameObject.transform.position;
        pos.y = Height;
        gameObject.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
