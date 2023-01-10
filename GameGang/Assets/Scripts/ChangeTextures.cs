using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextures : MonoBehaviour
{
   public Material chosenMat;
    public Material Mat1;
    public Material Mat2;
    public Material Mat3;
    public Material Mat4;
    public Material Mat5;
  /*  public Material Mat6;
    public Material Mat7;
    public Material Mat8;
    public Material Mat9;
    public Material Mat10;
    public Material Mat11;
    public Material Mat12;
    public Material Mat13;
    public Material Mat14;
*/
    public Material chosenSkybox;
    public Material Skybox1;
    public Material Skybox2;
    public Material Skybox3;
    public Material Skybox4;
    public Material Skybox5;
    public Material Skybox6;
    public Material Skybox7;

    public Component[] MR;


    // Start is called before the first frame update
    void Start()
    {
        float p;
        p = Random.value;
        if(p < 0.2f)
        {
            chosenMat = Mat1;
        }
        else if(p < 0.4 && p > 0.2)
        {
            chosenMat = Mat2;
        }
        else if (p < 0.6 && p > 0.4)
        {
            chosenMat = Mat3;
        }
        else if (p <0.8 && p > 0.6)
        {
            chosenMat = Mat4;
        }
        else if (p <= 1 && p > 0.8)
        {
            chosenMat = Mat5;
        }
       /* else if (p < 0.4294 && p > 0.3580)
        {
            chosenMat = Mat6;
        }
        else if (p < 0.5008 && p > 0.4294)
        {
            chosenMat = Mat7;
        }
        else if (p < 0.5722 && p > 0.5008)
        {
            chosenMat = Mat8;
        }
        else if (p < 0.6436 && p > 0.5722)
        {
            chosenMat = Mat9;
        }
        else if (p < 0.7150 && p > 0.6436)
        {
            chosenMat = Mat10;
        }
        else if (p < 0.7864 && p > 0.7150)
        {
            chosenMat = Mat11;
        }
        else if (p < 0.8578 && p > 0.7864)
        {
            chosenMat = Mat12;
        }
        else if (p < 0.9292 && p > 0.8578)
        {
            chosenMat = Mat13;
        }
        else if (p < 1 && p > 0.9292)
        {
            chosenMat = Mat14;
        }
        */
        if (chosenMat == Mat1 )
        {
            chosenSkybox = Skybox1;
        }
        else if (chosenMat == Mat2 )
        {
            chosenSkybox = Skybox2;
        }
        else if (chosenMat == Mat3 )
        {
            chosenSkybox = Skybox3;
        }
        else if (chosenMat == Mat4 )
        {
            chosenSkybox = Skybox4;
        }
        else if (chosenMat == Mat5 )
        {
            chosenSkybox = Skybox5;
        }
       /* else if (chosenMat == Mat6 || chosenMat == Mat13)
        {
            chosenSkybox = Skybox6;
        }
        else if (chosenMat == Mat7 || chosenMat == Mat14)
        {
            chosenSkybox = Skybox7;
        }
        */
        RenderSettings.skybox = chosenSkybox;
    }


    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ChangeTexture());
    }

    string[] tagsToDisable =
             {
                 
                 "Towers"
                 
             };
    IEnumerator ChangeTexture()
    {
        foreach (string tag in tagsToDisable)
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
            // float waitTime = 3f;
            foreach (GameObject Building in gameObjects)
            {
                yield return new WaitForSeconds(0);
                //  Building.GetComponentInChildren<MeshRenderer>().material = chosenMat;
                MR = Building.GetComponentsInChildren<MeshRenderer>(false);
                foreach (MeshRenderer MR in MR)
                    MR.material = chosenMat;

            }
        }
    }
}