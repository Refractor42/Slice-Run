using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyNode", 1f);
    }
    void DestroyNode()
    {
        GameObject.Destroy(gameObject);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
