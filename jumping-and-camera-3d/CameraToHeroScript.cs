using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToHeroScript : MonoBehaviour {
    private GameObject _hero = null;

    public float deltaHorizontal = 0.0f;
    public float deltaVertical = 0.0f;
    public float speedMoving = 0.0f;
    
    void Start() {
        _hero = GameObject.Find("Hero");
    }
    
    void LateUpdate() {
        Vector3 heroPosition = _hero.transform.position;
        Vector3 goalPosition = heroPosition - _hero.transform.forward * deltaHorizontal;
        goalPosition.y += deltaVertical;
        MoveToGoal(goalPosition);
        transform.LookAt(heroPosition);
    }

    void MoveToGoal(Vector3 goalPosition) {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            goalPosition, 
            speedMoving * Time.deltaTime
        );
    }
}
