using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    [SerializeField] private Vector2 vectorMoving = Vector2.zero;

    private Rigidbody2D _rigidbody2D = null;

    private void Start() {
        _rigidbody2D = GetterComponent.GetComp<Rigidbody2D>(gameObject);
    }

    private void FixedUpdate() {
        _rigidbody2D.velocity = vectorMoving;
    }
}
