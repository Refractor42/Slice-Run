using UnityEngine;

public enum TestMode
{
    Scene,
    Game
}

public class GraphEdge : MonoBehaviour
{
    public GraphNode StartNode;
    public GraphNode EndNode;
    public TestMode testMode = TestMode.Scene;
    public string leftNode;
    public string rightNode;


    bool Scaled = false;

    /* void FixedUpdate()
     {
         if (StartNode.transform.hasChanged || EndNode.transform.hasChanged)
         {
             Scale();
         }
     }*/
    void Start()
    {
        if (StartNode.transform || EndNode.transform)
        {
            Invoke("Scale", 0.1f);
        }
        //Invoke("FindOBJ", 0.1f);

        InvokeRepeating("ScaleLess", 0.1f, 0.1f); //prototype code, виж дали не може да се оптимизира леко например с FixedUpdate(){} и погледни защо се разширява от двете страни plane-a
        StartNode = GameObject.FindWithTag(leftNode).GetComponent<GraphNode>();
        EndNode = GameObject.FindWithTag(rightNode).GetComponent<GraphNode>();
    }
    void Update()
    {
        if (!Scaled)
            return;

        if (testMode == TestMode.Scene)
        {
            StartNode.transform.hasChanged = false;
            EndNode.transform.hasChanged = false;
        }
        Scaled = false;
    }

    void Scale()
    {
        float distance = Vector3.Distance(StartNode.transform.position, EndNode.transform.position); //Change Scale
        transform.localScale = new Vector3(0.25f, 4.5f, distance);

        Vector3 middlePoint = (StartNode.transform.position + EndNode.transform.position) / 2; //Change Position
        transform.position = middlePoint;

        Vector3 rotationDirection = (EndNode.transform.position - StartNode.transform.position); //Change Rotation
        transform.rotation = Quaternion.LookRotation(rotationDirection);

        Scaled = true;
    }
    public void FindOBJ()
    {
        StartNode = GameObject.FindWithTag("LeftNode").GetComponent<GraphNode>();
        EndNode = GameObject.FindWithTag("RightNode").GetComponent<GraphNode>();
    }

    void ScaleLess()
    {
        float distance = Vector3.Distance(StartNode.transform.position, EndNode.transform.position); //Change Scale
        transform.localScale = new Vector3(0.25f, 4.5f, distance);

        Vector3 middlePoint = (StartNode.transform.position + EndNode.transform.position) / 2; //Change Position
        transform.position = middlePoint;

        Vector3 rotationDirection = (EndNode.transform.position - StartNode.transform.position); //Change Rotation
        transform.rotation = Quaternion.LookRotation(rotationDirection);
        
        Scaled = true;
    }
}