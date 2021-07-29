using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerS : MonoBehaviour
{
    public AudioClip[] sounds=new AudioClip[5];
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            audioSource.PlayOneShot(sounds[0]);
        }
    }
}
