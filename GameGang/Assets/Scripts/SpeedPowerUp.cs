using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class SpeedPowerUp : MonoBehaviour
{
    public GameObject Player;
    float OldSpeed;
    float OldSpeed2;
    PlayerControls PCLS;
    float i = 0;
    public CameraController CameraController;
    
    float step = 0.05f;

    public Transform target;
    
    public CameraShaker CamShake;

    public ObjectSetPosition setpos;

    public SpawnPowerUps pwrscript;

   
    
   
    // Start is called before the first frame update
    void Start()
    {
       Player =  GameObject.FindWithTag("Player");
        CamShake = GameObject.FindWithTag("MainCamera").GetComponent<CameraShaker>();
        PCLS = GameObject.FindWithTag("GameController").GetComponent<PlayerControls>();
        target = GameObject.FindWithTag("Target").transform;
        CameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
        setpos = GameObject.FindWithTag("CubeNavigacion").GetComponent<ObjectSetPosition>();
        pwrscript = GameObject.FindWithTag("CubeNavigacion").GetComponent<SpawnPowerUps>();
      
     
    }
  
    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
      
        OldSpeed = Player.GetComponent<DragObject>().ForwardSpeed;
        
        Player.GetComponent<DragObject>().ForwardSpeed += 20;
        


        PCLS.Invoke("SetActiveJet", 0f);
        i = 1;
        
        Invoke("ReturnToNormal", 10f);
        Invoke("StopShaking", 10f);
       

        
       
        Invoke("GoUp", 0f);
        CameraController.Invoke("FourthView", 0.4f);
        setpos.Invoke("SetPosUp", 0f);
        pwrscript.Invoke("IntenseMoney", 0f);
        pwrscript.isItInAir = true;

    }

    public void GoUp()
    {
        if(Player.transform.position.y < 5)
        {
            Player.transform.position = Vector3.MoveTowards(Player.transform.position, target.position, step);
            Invoke("GoUp", 0f);
            Debug.Log("GoUp");

        }


    }
    public void ReturnToNormal()
    {
      
        Player.GetComponent<DragObject>().ForwardSpeed = OldSpeed;
        Player.GetComponent<MeshCollider>().enabled = true;
        CameraController.Invoke("DefaultView", 0.4f);
        
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        Invoke("Fall", 0.1f);
        Invoke("FinalAdjustments", 1f);
        setpos.Invoke("SetPosDown", 0f);
        pwrscript.Invoke("NormalMoney", 0f);
        pwrscript.isItInAir = false;
        Invoke("Destroy", 2.1f);
    }

    public void Fall()
    {
        Player.GetComponent<DragObject>().enabled = false;
    }
    public void FinalAdjustments()
    {
        Player.GetComponent<DragObject>().enabled = true;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        
    }
    private void Update()
    {
        if (i == 1)
        {
          
            CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 0.1f);
        }
        else
        {
            CamShake.enabled = false;
        }
       

    }
    public void StopShaking()
    {
        i = 0;
    }
    public void Destroy()
    {

        Destroy(this);

    }
}
