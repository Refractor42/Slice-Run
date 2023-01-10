using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPointsAudio : MonoBehaviour
{
    public GameObject Audio2;
    public AudioClip AudioClip2;
    // Start is called before the first frame update
    void Start()
    {
        Audio2 = GameObject.FindWithTag("AudioSource2");
        AudioClip2 = Audio2.GetComponent<AudioSource>().clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        Audio2.GetComponent<AudioSource>().PlayOneShot(AudioClip2, 0.01f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
