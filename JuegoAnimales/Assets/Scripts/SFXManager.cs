using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    public AudioClip a_sound;
    public AudioClip b_sound;
    public AudioClip c_sound;
    public AudioClip d_sound;
    public AudioClip e_sound;
    public AudioClip f_sound;
    public AudioClip g_sound;
    public AudioClip i_sound;
    public AudioClip j_sound;
    public AudioClip l_sound;
    public AudioClip m_sound;
    public AudioClip n_sound;
    public AudioClip o_sound;
    public AudioClip r_sound;
    public AudioClip s_sound;
    public AudioClip t_sound;
    public AudioClip u_sound;
    public AudioClip v_sound;
    public AudioClip z_sound;

    

    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if(instance == null)
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
