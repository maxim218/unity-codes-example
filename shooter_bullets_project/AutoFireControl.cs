using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireControl : MonoBehaviour {
    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            PlayerScript playerScript = gameObject.GetComponent<PlayerScript>();
            playerScript.ReverseMouseDown();
        }
    }
}
