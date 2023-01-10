using UnityEngine;
using System.Collections;

public class ExampleUseof_MeshCut : MonoBehaviour {

	public Material capMaterial;
    public Rigidbody rbcp;
   public GameObject CutPart;
  // public GameObject Player;
  //  public BoxCollider PC;
   public GameObject Controller;
    public ExternalSetActive EXTSA;
    public PhysicMaterial physicMaterial;
    public GameObject Audio1;
    public AudioClip AudioClip1;
    public bool PlayerInteractable = false;
    public SetActiveCutSides SAscript;
    // Use this for initialization
    void Start () {

        //SAscript = GameObject.FindWithTag("GameController").GetComponent<SetActiveCutSides>();
    
	}
	
	void Update(){

		
			RaycastHit hit;

			if(Physics.Raycast(transform.position, transform.forward, out hit)){
                 
				GameObject victim = hit.collider.gameObject;

				GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);
            //   Player = GameObject.Find("left side");
            //  PC = Player.GetComponent<BoxCollider>();

            if (PlayerInteractable == true)
            {
                Controller = GameObject.Find("Controller");
                EXTSA = Controller.GetComponent<ExternalSetActive>();
            }
            if (!pieces[1].GetComponent<Rigidbody>())
					pieces[1].AddComponent<Rigidbody>();

            //Destroy(PC);
            if (PlayerInteractable == true)
            {
                EXTSA.Invoke("AddCollider", 0f);
            }

            if (PlayerInteractable == false)
            {
                //  SAscript.Invoke("SetActiveAgain", 0.2f);
                Destroy(pieces[1], 0);
            }

            if (PlayerInteractable == true)
            {
              //  Debug.Log("AudioPlayed");
                pieces[1].layer = 13;
                pieces[1].AddComponent<MeshCollider>();
                pieces[1].GetComponent<MeshCollider>().material = physicMaterial;
                pieces[1].GetComponent<MeshCollider>().convex = true;
                pieces[1].GetComponent<MeshRenderer>().material.enableInstancing = true;
                CutPart = GameObject.Find("right side");
                CutPart.AddComponent<MeshCollider>();
                CutPart.GetComponent<MeshCollider>().material = physicMaterial;
                CutPart.GetComponent<MeshCollider>().convex = true;
                // Debug.Log("PhysicMaterialAdded = " + physicMaterial);
                rbcp = pieces[1].GetComponent<Rigidbody>();
                rbcp.mass = 100;
                Vector3 vel = rbcp.velocity;
                vel.x = 0 - 4.95f;
                rbcp.velocity = vel;
                Destroy(pieces[1], 5);
                gameObject.GetComponentInParent<RightObjectLoader>().currentObstacle = true;
                gameObject.GetComponentInParent<LeftObjectLoader>().currentObstacle = true;
            }
 
           

            if (PlayerInteractable == true)
            { gameObject.SetActive(false);
                
                Audio1 = GameObject.FindWithTag("AudioSource1");
                AudioClip1 = Audio1.GetComponent<AudioSource>().clip;
                Audio1.GetComponent<AudioSource>().PlayOneShot(AudioClip1, 1);
            }
        }
       
	}
    
	void OnDrawGizmosSelected() {

		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, transform.position + transform.forward * 5.0f);
		Gizmos.DrawLine(transform.position + transform.up * 0.5f, transform.position + transform.up * 0.5f + transform.forward * 5.0f);
		Gizmos.DrawLine(transform.position + -transform.up * 0.5f, transform.position + -transform.up * 0.5f + transform.forward * 5.0f);

		Gizmos.DrawLine(transform.position, transform.position + transform.up * 0.5f);
		Gizmos.DrawLine(transform.position,  transform.position + -transform.up * 0.5f);

	}

}
