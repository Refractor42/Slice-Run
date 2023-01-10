using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalSetActive : MonoBehaviour
{
    public GameObject Blade;
    public GameObject Player;
    public MeshCollider PC;
    public PhysicMaterial ZeroFriction;
    public GameObject CutSide1;
    public GameObject CutSide2;
    
    
    private void Start()
    {
        Blade.SetActive(true);
        
    }

   public void SetActiveAgain()
    {
        CutSide1.SetActive(true);
        CutSide2.SetActive(true);
    }
    void AddCollider()
    {
       
        
        Invoke("RealAddCollider", 0f);

    }
    void RealAddCollider()
    {
        Player = GameObject.FindWithTag("Player");
        PC = Player.GetComponent<MeshCollider>();
       
        DestroyImmediate(PC);
        Player.AddComponent<MeshCollider>();
        Player.GetComponent<MeshCollider>().convex = true;



    }
}
