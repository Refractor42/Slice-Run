using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public GameObject[] characterList;
    private int index;
    GameObject SelectedObj;
    GameObject leftside;
    public int objstate;
    public GameObject SaveManager;
    public ObjectState Script;
    public GameObject SelectButton;
    public GameObject BackButton;
    public GameObject BuyButton;
    public GameObject PremiumBuyButton;
    public int SelectedObject;
  
    
    private void Start()
    {
     
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)

            characterList[i] = transform.GetChild(i).gameObject;
                

       
        
        IEnumerator ExampleCoroutine()
        {
            //Print the time of when the function is first called.

            //yield on a new YieldInstruction that waits for 5 seconds.
           

            yield return new WaitForSecondsRealtime(0.2f);

            foreach (GameObject go in characterList)
        
            go.SetActive(false);
            
            //After we have waited 5 seconds print the time again.

        }
        
        StartCoroutine(ExampleCoroutine());
        StartCoroutine(Coroutine2());
        


 SelectedObj = GameObject.FindGameObjectWithTag("Mesh");
        leftside = GameObject.Find("left side");
        leftside.GetComponent<MeshFilter>().mesh = SelectedObj.GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshRenderer>().materials = SelectedObj.GetComponent<MeshRenderer>().materials;



    }

IEnumerator Coroutine2()
        {
            //Print the time of when the function is first called.

            //yield on a new YieldInstruction that waits for 5 seconds.


            yield return new WaitForSecondsRealtime(0.2f);

            if (characterList[index])
            characterList[index].SetActive(true);

            SelectedObj = GameObject.FindGameObjectWithTag("Mesh");
            leftside = GameObject.Find("left side");
            leftside.GetComponent<MeshFilter>().mesh = characterList[index].GetComponent<MeshFilter>().mesh;
            leftside.GetComponent<MeshCollider>().sharedMesh = characterList[index].GetComponent<MeshFilter>().mesh;
            leftside.GetComponent<MeshRenderer>().materials = SelectedObj.GetComponent<MeshRenderer>().materials;
            
            leftside = GameObject.Find("left side");
            leftside.GetComponent<MeshFilter>().mesh = SelectedObj.GetComponent<MeshFilter>().mesh;
            leftside.GetComponent<MeshCollider>().sharedMesh = characterList[index].GetComponent<MeshFilter>().mesh;
            leftside.GetComponent<MeshRenderer>().materials = SelectedObj.GetComponent<MeshRenderer>().materials;
        }
    public void ToggleLeft()
    {
        
        
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        };
      
        characterList[index].SetActive(true);
        SelectedObj = GameObject.FindGameObjectWithTag("Mesh");
        leftside = GameObject.Find("left side");
        leftside.GetComponent<MeshFilter>().mesh = SelectedObj.GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshCollider>().sharedMesh = characterList[index].GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshRenderer>().materials = SelectedObj.GetComponent<MeshRenderer>().materials;
        

       
       
    }
    public void ToggleRight()
    {
         
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }
        characterList[index].SetActive(true);
        SelectedObj = GameObject.FindGameObjectWithTag("Mesh");
        leftside = GameObject.Find("left side");
        leftside.GetComponent<MeshFilter>().mesh = SelectedObj.GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshCollider>().sharedMesh = characterList[index].GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshRenderer>().materials = SelectedObj.GetComponent<MeshRenderer>().materials;

    }
    public void BackButtonScript()
    {
        // PlayerPrefs.SetInt("CharacterSelected", index);
        PlayerPrefs.GetInt("CharacterSelected", index);
       

    }
    public void SelectButtonSave()
    {

        PlayerPrefs.SetInt("CharacterSelected", index);

    }

    
    public void FindScript()
    {
        //Debug.Log("FindScriptInvoked");
        Script = GameObject.FindGameObjectWithTag("Mesh").GetComponent<ObjectState>();
        objstate = Script.objstate;
    }
    

    public void IsItPlayable()
    {
        // foreach(GameObject.FindGameObjectsWithTag("Mesh") in characterList);
        Script = GameObject.FindGameObjectWithTag("Mesh").GetComponent<ObjectState>();
        objstate = Script.objstate;
       // Debug.Log("ObjState is:" + objstate);
        //Debug.Log("ScriptObjState is:" + Script.objstate);
        if (GameObject.FindGameObjectWithTag("Mesh").activeInHierarchy)
        {
           
            if (objstate == 1)
            {
                BuyButton.SetActive(false);
                PremiumBuyButton.SetActive(false);
                SelectButton.SetActive(true);
                BackButton.SetActive(true);
              //  Debug.Log("SelectButtonActive");
            }
            else
            {

                BuyButton.SetActive(true);
                PremiumBuyButton.SetActive(true);
                SelectButton.SetActive(false);
                BackButton.SetActive(false);
              //  Debug.Log("BuyButtonActive");

            }
           // Debug.Log("IsItPlayable");
        }
    }
 public void Revive()
    {
        Debug.Log("InvokedReviveOS");
        SelectedObj = GameObject.FindGameObjectWithTag("Mesh");
        leftside = GameObject.Find("left side");
        leftside.GetComponent<MeshFilter>().mesh = SelectedObj.GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshCollider>().sharedMesh = characterList[index].GetComponent<MeshFilter>().mesh;
        leftside.GetComponent<MeshRenderer>().materials = SelectedObj.GetComponent<MeshRenderer>().materials;
        

    }
}
