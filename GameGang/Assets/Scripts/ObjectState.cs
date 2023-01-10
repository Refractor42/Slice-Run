using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectState : MonoBehaviour
{
   // public GameObject[] OScharacterList;
   // public GameObject MeshList;
   // public int index;
  //  public ObjectSelector objscript;
    public int objstate;
  //  int i;
    public string OBJSTATEKEY;
    // Start is called before the first frame update
    void Start()
    {

        /*  OScharacterList = objscript.characterList;
          for (i = 0; i < MeshList.transform.childCount; i++)
              OScharacterList[i] = MeshList.transform.GetChild(i).gameObject;
  */
        // objstate = PlayerPrefs.GetInt("OBJSTATE");
        objstate = PlayerPrefs.GetInt(OBJSTATEKEY);

    }

    // Update is called once per frame
    void Update()
    {
        //PlayerPrefs.SetInt("OBJSTATE", objstate);

    }
    public void SetInt()
    {
        PlayerPrefs.SetInt(OBJSTATEKEY, objstate);
        
    }
    public void GetInt()
    {
        objstate = PlayerPrefs.GetInt(OBJSTATEKEY);
     
    }
}
