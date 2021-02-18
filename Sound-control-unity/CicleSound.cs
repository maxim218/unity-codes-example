using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicleSound : MonoBehaviour {
    [SerializeField] private AudioClip clipMy;
    private AudioSource _audioSource = null;
    
    void Start() {
        _audioSource = gameObject.GetComponent<AudioSource>();
        _audioSource.clip = clipMy;
        _audioSource.loop = true;
        _audioSource.Play();
    }

    void Update() {
        GameObject cam = GameObject.Find("Main Camera");
        float currentDistance = Vector3.Distance(gameObject.transform.position, cam.transform.position);
        float longestDistance = 18.0f;
        float k = (longestDistance - currentDistance) / longestDistance;
        _audioSource.volume = k * 0.5f;
    }
}
