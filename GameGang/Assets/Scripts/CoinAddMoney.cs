using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAddMoney : MonoBehaviour
{
    AddSubtractPlayerMoney ADSPM;
    Player player;
    public GameObject Coins;

   
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.Find("Save").GetComponent<Player>();
        ADSPM = GameObject.Find("MoneyHandler").GetComponent<AddSubtractPlayerMoney>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        AddMoney();
        player.SavePlayer();
        gameObject.SetActive(false);
        GameObject.Instantiate(Coins);

    }
    public void AddMoney()
    {

        ADSPM.money = ADSPM.money + 1;
        player.money = player.money + 1;

    }
}
