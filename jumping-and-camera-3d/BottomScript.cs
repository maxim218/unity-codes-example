using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScript : MonoBehaviour {
    private HeroScript _heroScript = null;
    
    void Start() {
        GameObject hero = GameObject.Find("Hero");
        _heroScript = hero.GetComponent<HeroScript>();
    }
    
    void OnTriggerEnter(Collider other) {
        _heroScript.SetCanJump(true);
    }

    void OnTriggerExit(Collider other) {
        _heroScript.SetCanJump(false);
    }
}
