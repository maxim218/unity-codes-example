using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {
    private GameObject [] _redArray = null;
    private GameObject [] _greenArray = null;
    private GameObject [] _blueArray = null;

    private void Start() {
        _redArray = GameObject.FindGameObjectsWithTag("TagRed");
        _greenArray = GameObject.FindGameObjectsWithTag("TagGreen");
        _blueArray = GameObject.FindGameObjectsWithTag("TagBlue");
    }

    private static void MoveElements(GameObject [] arr, float speedX, float speedY) {
        if (arr == null) return;
        if (arr.Length == 0) return;
        foreach (GameObject element in arr) {
            const int zero = 0;
            element.transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, zero);
        }
    }
   
    private void Update() {
        MoveElements(_redArray, -2, 0);
        MoveElements(_greenArray, 0, 1);
        MoveElements(_blueArray, 1, 0);
    }
}
