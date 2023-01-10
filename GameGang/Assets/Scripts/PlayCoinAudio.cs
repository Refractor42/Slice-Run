using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCoinAudio : MonoBehaviour
{
    public GameObject Audio3;
    public AudioClip AudioClip3;
    // Start is called before the first frame update
    void Start()
    {
        Audio3 = GameObject.FindWithTag("AudioSource3");
        AudioClip3 = Audio3.GetComponent<AudioSource>().clip;

    }
    private void OnTriggerEnter(Collider other)
    {
       
        Audio3.GetComponent<AudioSource>().PlayOneShot(AudioClip3, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
