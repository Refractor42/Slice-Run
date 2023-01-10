using UnityEngine;
using System.Collections;
public class AddSubtractPlayerMoney : MonoBehaviour
{

    
    public GameObject Player;
    public int money;
    public int pmoney;
    public GameObject SaveMoney;
    public int objstate;
    public ObjectSelector objSelector;
    public GameObject GameController;
   // public GameObject NEM;
   // public GameObject MEM;
    public ObjectState objscript;
    public GameObject[] Obstacles;
    // Use this for 1nitlallzation
    void Start()
    {
      money = SaveMoney.GetComponent<Player>().money;
        pmoney = SaveMoney.GetComponent<Player>().pmoney;
        objSelector = GameObject.FindWithTag("MeshList").GetComponent<ObjectSelector>();
        GameController = GameObject.FindWithTag("GameController");
    }
    // Update 15 called once per frame
    void Update()
    {
    /*    if (Input.GetButtonDown("Fire1"))
        {
            Player.GetComponent<PlayerMoney>().addMoney(100);
        }
        if (Input.GetButtonDown("Fire2")) {
            Player.GetComponent<PlayerMoney>().addMoney(-100);
       }*/
    }

  

    public void BuyCharacter()
    {
        if (money - 1000 < 0)
        {
           
         //  NEM.SetActive(true);
        }
        else
        {
            objscript = GameObject.FindWithTag("Mesh").GetComponent<ObjectState>();
            
            money -= 1000;
           // MEM.SetActive(true);
            objscript.objstate = 1;
           

            objscript.Invoke("SetInt", 0f);
            objscript.Invoke("GetInt", 0f);
            objSelector.Invoke("IsItPlayable", 0f);
            Debug.Log("Invoked");
            SaveMoney.GetComponent<Player>().money = money;

        }
       // Player.GetComponent<PlayerMoney>().addMoney(-1000);
    }

    public void PremiumBuyCharacter()
    {
        if (pmoney - 10 < 0)
        {

            //  NEM.SetActive(true);
        }
        else
        {
            objscript = GameObject.FindWithTag("Mesh").GetComponent<ObjectState>();

            pmoney -= 10;
            // MEM.SetActive(true);
            objscript.objstate = 1;


            objscript.Invoke("SetInt", 0f);
            objscript.Invoke("GetInt", 0f);
            objSelector.Invoke("IsItPlayable", 0f);
            Debug.Log("Invoked");
            SaveMoney.GetComponent<Player>().pmoney = pmoney;
            Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
            foreach (GameObject go in Obstacles)
            {
                Destroy(go);
            }

        }
        // Player.GetComponent<PlayerMoney>().addMoney(-1000);
    }

    public void PremiumRevive()
    {
        if (pmoney - 1 < 0)
        {

            //  NEM.SetActive(true);
        }
        else
        {
           

            pmoney -= 1;
            // MEM.SetActive(true);
            GameController.GetComponent<UIControls>().Invoke("HideRevive", 0f);
            GameObject.FindWithTag("AddScore").GetComponent<Score>().Invoke("ReviveScore", 0f);

            objSelector.Invoke("Revive", 0f);
        
            
            SaveMoney.GetComponent<Player>().pmoney = pmoney;

        }
        // Player.GetComponent<PlayerMoney>().addMoney(-1000);
    }

    public void ResetOBJSTATE()
    {
        objscript = GameObject.FindWithTag("Mesh").GetComponent<ObjectState>();
        objscript.objstate = 0;

        objscript.Invoke("SetInt", 0f);
        objscript.Invoke("GetInt", 0f);
    }
  
}
