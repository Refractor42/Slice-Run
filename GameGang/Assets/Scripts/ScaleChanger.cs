using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    Vector3 scale;
    public float newScaleY;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ScaleChange());

    }
    IEnumerator ScaleChange()
    {
        yield return new WaitForSeconds(0.3f);
        scale = gameObject.transform.localScale;
        scale.y = newScaleY;
        gameObject.transform.localScale = scale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.transform.localScale.y != 3.5f)
        {
            
        }
    }

    
}
