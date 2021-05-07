using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX2Manager : MonoBehaviour
{
    public static SFX2Manager instance;

    public AudioClip drag;
    public AudioClip succes;
    public AudioClip fail;
    public AudioClip victory;

    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlaySFX(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
