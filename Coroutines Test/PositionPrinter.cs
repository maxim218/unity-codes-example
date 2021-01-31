using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPrinter : MonoBehaviour {
    private GameObject _heroA = null;
    private float _posX = 0.0f;
    
    void Start() {
        _heroA = GameObject.Find("heroA");
        _posX = _heroA.transform.position.x;
        StartCoroutine(PositionWatching());
    }

    IEnumerator PositionWatching() {
        while (true) {
            _posX = _heroA.transform.position.x;
            yield return new WaitForSeconds(1);
            if (_posX < -6.0f) {
                Debug.Log("Stop");
                yield break;
            }
        }
    }

    void OnGUI() {
        var message = "\n" + "X: " + _posX + "\n";
        GUI.Box(new Rect(360, 25, 150, 50), message);
    }
}
