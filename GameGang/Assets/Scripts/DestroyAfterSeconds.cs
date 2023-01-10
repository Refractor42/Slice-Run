using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", seconds);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
