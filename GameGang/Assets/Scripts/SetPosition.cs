using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
   
    Vector3 pos;
    public GameObject Parent;//set the parent when u can and see if it works

  /*  public bool ParentNode;
    // Start is called before the first frame update
    void Start()
    {
        if (ParentNode == true)
        {
            this.gameObject.transform.position = Parent.transform.position;
        }
        else
        {
            pos = Parent.transform.position;


            this.gameObject.transform.localPosition = pos;
        }
    }
    */
    // Update is called once per frame
    void Update()
    {
        pos = Parent.transform.position;
        pos.y = 1;
        this.gameObject.transform.position = pos;
    }
}
