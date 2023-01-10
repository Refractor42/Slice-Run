using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class PlayerMoney : MonoBehaviour
{
    int Common = 1200;
    int Uncommon = 1500;
    int Rare = 2500;
    int Epic = 5000;
    int Legendary = 12000;
    
    public static int money;
    public static int pmoney;
    // Use this for initialization
    void Start()
    {
        
     
    }
    // Update 15 called once per frame

    void Update()
    {

        
       
    }
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
        
      
    }

    public void addPmoney(int pmoneyToAdd)
    {
        pmoney += pmoneyToAdd;
    }

    public void MoneyChecker()
    {
      


    }
    
}
