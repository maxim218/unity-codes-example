using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerSounds : MonoBehaviour {
    private AudioSource _audioSource = null;
    
    [SerializeField] private AudioClip clipA;
    [SerializeField] private AudioClip clipB;
    [SerializeField] private AudioClip clipC;

    void Start() {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void StopTheSounds() {
        _audioSource.Stop();
    }
    
    public void SoundThisRun(string soundName) {
        switch (soundName) {
            case "A":
                _audioSource.PlayOneShot(clipA);
                break;
            case "B":
                _audioSource.PlayOneShot(clipB);
                break;
            case "C":
                _audioSource.PlayOneShot(clipC);
                break;
        }
    }
}
