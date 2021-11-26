using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMyControl : MonoBehaviour
{
    private float _speed = 0;

    public void SetSpeed(float speedValue)
    {
        _speed = speedValue;
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
    
    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
