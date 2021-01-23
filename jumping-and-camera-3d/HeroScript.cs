using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour {
    public float moveSpeed = 0.0f;
    public float rotateSpeed = 0.0f;
    public float jumpForce = 0.0f;
    
    private bool _w = false;
    private bool _s = false;
    private bool _a = false;
    private bool _d = false;

    private Rigidbody _rigidbody;

    private bool _canJump = false;

    public void SetCanJump(bool flag) {
        _canJump = flag;
    }

    private void DownKeyControl() {
        if (Input.GetKeyDown(KeyCode.W)) _w = true;
        if (Input.GetKeyDown(KeyCode.A)) _a = true;
        if (Input.GetKeyDown(KeyCode.S)) _s = true;
        if (Input.GetKeyDown(KeyCode.D)) _d = true;
    }

    private void UpKeyControl() {
        if (Input.GetKeyUp(KeyCode.W)) _w = false;
        if (Input.GetKeyUp(KeyCode.A)) _a = false;
        if (Input.GetKeyUp(KeyCode.S)) _s = false;
        if (Input.GetKeyUp(KeyCode.D)) _d = false;
    }

    private void MoveHero() {
        if(_w) transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        if(_s) transform.Translate(0, 0, -1 * moveSpeed * Time.deltaTime);
    }

    private void RotateHero() {
        if(_d) transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        if(_a) transform.Rotate(0, -1 * rotateSpeed * Time.deltaTime, 0);
    }

    private void JumpControl() {
        if (Input.GetKeyDown(KeyCode.Space)) 
            if(_canJump == true)
                _rigidbody.AddForce(transform.up * jumpForce);
    }
    
    void Start() {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    
    void Update() {
        // keys
        DownKeyControl();
        UpKeyControl();
        // move
        MoveHero();
        // rotate
        RotateHero();
        // jump
        JumpControl();
    }
}
