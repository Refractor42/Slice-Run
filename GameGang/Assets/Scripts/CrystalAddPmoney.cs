using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalAddPmoney : MonoBehaviour
{
    AddSubtractPlayerMoney ADDSPM;
    Player player;
    public GameObject CrystalGraphic;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Save").GetComponent<Player>();
        ADDSPM = GameObject.Find("MoneyHandler").GetComponent<AddSubtractPlayerMoney>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        AddPMoney();
        player.SavePlayer();
        gameObject.SetActive(false);
        GameObject.Instantiate(CrystalGraphic);

    }
    public void AddPMoney()
    {

        ADDSPM.pmoney = ADDSPM.pmoney + 1;
        player.pmoney = player.pmoney + 1;

    }
}

