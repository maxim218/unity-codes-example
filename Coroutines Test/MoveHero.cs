using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour {
    private bool _canMove = false;

    public void AllowMove() {
        _canMove = true;
    }
    
    void Update() {
        if (_canMove) {
            const float speedMove = 1.5f;
            gameObject.transform.Translate(0, 0, speedMove * Time.deltaTime);
        }
    }
}
