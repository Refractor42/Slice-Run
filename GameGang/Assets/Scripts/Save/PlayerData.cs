using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int money;
    public int pmoney;


    public PlayerData (Player player)
    {
      

        money = player.money;
        pmoney = player.pmoney;
   
    }
}
