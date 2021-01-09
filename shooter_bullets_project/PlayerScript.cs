using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AutoFireControl))]

public class PlayerScript : MonoBehaviour {
    private float _rotationX = 0.0f;
    private float _rotationY = 0.0f;
    private GameObject _camera = null;
    private GameObject _pistol = null;

    private bool _w = false;
    private bool _s = false;

    [SerializeField] private GameObject bulletPrefab = null;

    private void RotationLeftRight(float speedRotating) {
        float delta = Input.GetAxis("Mouse X") * speedRotating;
        _rotationY = transform.localEulerAngles.y + delta;
        gameObject.transform.localEulerAngles = new Vector3(0, _rotationY, 0);
    }

    private void RotationTopBottom(float speedRotating) {
        _rotationX -= Input.GetAxis("Mouse Y") * speedRotating;
        _rotationX = Mathf.Clamp(_rotationX, -45, 45);
        _camera.transform.localEulerAngles = new Vector3(_rotationX, 0, 0);
    }
    
    private void ControlDown() {
        if (Input.GetKeyDown(KeyCode.W)) _w = true;
        if (Input.GetKeyDown(KeyCode.S)) _s = true;
    }

    private void ControlUp() {
        if (Input.GetKeyUp(KeyCode.W)) _w = false;
        if (Input.GetKeyUp(KeyCode.S)) _s = false;
    }
    
    private void MoveRobot(float moveSpeed) {
        if(_w) transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        if(_s) transform.Translate(0, 0, -1 * moveSpeed * Time.deltaTime);
    }

    private bool _canFire = true;

    public void AllowFire() {
        _canFire = true;
    }

    public void BulletFire() {
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;
        bullet.transform.position = _camera.transform.Find("pricelCamera").gameObject.transform.TransformPoint(Vector3.forward);
        bullet.transform.rotation = _camera.transform.rotation;
        ////////
        Rigidbody rrr = bullet.GetComponent<Rigidbody>();
        Vector3 vvv = bullet.transform.forward * 9000;
        rrr.AddForce(vvv);
    }

    [SerializeField] private bool mouseAlwaysDown = false;

    public void ReverseMouseDown() {
        mouseAlwaysDown = !mouseAlwaysDown;
    }
    
    private bool IsMouseDown() {
        return mouseAlwaysDown || Input.GetMouseButtonDown(0);
    }
    
    private void FireControl() {
        if (IsMouseDown()) {
            if (_canFire) {
                Animator anim = _pistol.GetComponent<Animator>();
                anim.CrossFade("PistolAnimation", 0);
                _canFire = false;
            }
        }
    }

    private void CursorForGame() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    void Start() {
        _camera = gameObject.transform.Find("Main Camera").gameObject;
        _pistol = _camera.transform.Find("Pistol").gameObject;
        CursorForGame();
    }
    
    void Update() {
        ControlDown();
        ControlUp();
        ////////
        const float speedRotating = 5.0f;
        RotationLeftRight(speedRotating);
        RotationTopBottom(speedRotating);
        ////////
        const float moveSpeed = 6.0f;
        MoveRobot(moveSpeed);
        ////////
        FireControl();
    }
}
