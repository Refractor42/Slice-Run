using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public static int MoneyTranslator = PlayerMoney.money;
    public static int PMoneyTranslator = PlayerMoney.pmoney;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI moneyText2;
    public TextMeshProUGUI moneyText3;
    public TextMeshProUGUI moneyText4;

    public TextMeshProUGUI pmoneyText;
    public TextMeshProUGUI pmoneyText2;
    public TextMeshProUGUI pmoneyText3;
    public TextMeshProUGUI pmoneyText4;

  

    private bool i = true;

    

    public int money;
    public int pmoney;

   

    void OnApplicationQuit()
    {
        SaveSystem.SavePlayer(this);
    }

    private void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        
        money = data.money;
        MoneyTranslator = money;

        pmoney = data.pmoney;
        PMoneyTranslator = pmoney;

        //////////////////////////////////////////////////
       

  

    }

    public void AddMoney()
    {
        money += 10000;


    }
    
    public void AddPmoney()
    {

        pmoney += 10000;

    }


    public void MoneyCheckerPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        money = data.money;
        pmoney = data.pmoney;

       



     
    }
    private void Update()
    {
        moneyText.text = money.ToString();
        moneyText2.text = money.ToString();
        moneyText3.text = money.ToString();
        moneyText4.text = money.ToString();

        pmoneyText.text = pmoney.ToString();
        pmoneyText2.text = pmoney.ToString();
        pmoneyText3.text = pmoney.ToString();
        pmoneyText4.text = pmoney.ToString();

        

    }
    public void SavePlayer()
    {
                SaveSystem.SavePlayer(this);
        
        
        
    }

    public void LoadPlayer()
    {

          
        
        
        PlayerData data = SaveSystem.LoadPlayer();
        

        money = data.money;
        MoneyTranslator = money;
       Debug.Log(MoneyTranslator);

        pmoney = data.pmoney;
        PMoneyTranslator = pmoney;

       



    }
}
