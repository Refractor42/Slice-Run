using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    // Use this for initialization
    void Start()
    {


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = views[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentView = views[2];
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentView = views[3];
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentView = views[4];
        }

    }

    public void DefaultView()
    {

        currentView = views[0];

    }

public void SecondView()
    {

        currentView = views[1];

    }

    public void ThirdView()
    {

        currentView = views[2];
    }
    public void FourthView()
    {
        currentView = views[3];
    }
    void LateUpdate()
    {

        //Lerp position
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.unscaledDeltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
         Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.unscaledDeltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.unscaledDeltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.unscaledDeltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;

    }
}