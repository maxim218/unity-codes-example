using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyTestScript : MonoBehaviour
{
    [SerializeField] private BallMyControl ballMyControl = null;
    
    private void Update()
    {
        const float speedMove = 1.0f;
        transform.Translate(speedMove * Time.deltaTime, 0, 0);
    }
    
    private void OnMouseDown()
    {
        BallMyControl script = Instantiate(ballMyControl);

        Vector3 position = transform.position;
        position.y -= 1.5f;
        script.SetPosition(position);

        const float speed = -1.1f;
        script.SetSpeed(speed);
    }
}
