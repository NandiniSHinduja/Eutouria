using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpAnimatorController : MonoBehaviour
{
    public AudioSource hpAudioSource;
    public bool isAudioFinished;
    public Animator hpAnimator;
    void Start()
    {
        hpAudioSource = GetComponent<AudioSource>();
        hpAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (!hpAudioSource.isPlaying)
        {
            isAudioFinished = true;
        }
        if (isAudioFinished)
        {
            hpAnimator.SetBool("isAudioFinished", true);
            isAudioFinished = false;
        }
    }
}
