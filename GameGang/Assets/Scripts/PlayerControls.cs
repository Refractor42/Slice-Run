using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] gameObjects;
    public GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        gameObjects = GameObject.FindGameObjectsWithTag("Boost");
        foreach (GameObject Boost in gameObjects)
        {
           
            Boost.SetActive(false);

        }
    }

    public void SetActiveJet()
    {

        foreach (GameObject Boost in gameObjects)
        {

            Boost.SetActive(true);

        }
        Score.GetComponent<Score>().enabled = false;
        Invoke("SetInactiveJet", 10f);

    }

    public void SetInactiveJet()
    {

        foreach (GameObject Boost in gameObjects)
        {

            Boost.SetActive(false);

        }
        Score.GetComponent<Score>().enabled = true;
    }
    public void StopFromFalling()
    {
        Invoke("SFM", 3f);
        

    }
   

    public void SFM()
    {

        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
