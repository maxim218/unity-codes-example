using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterControl : MonoBehaviour {
    void Start() {
        StartCoroutine(Counting());
    }

    void OnGUI() {
        var message = "\n" + _countNumber + "\n";
        GUI.Box(new Rect(300, 25, 40, 50), message);
    }

    private int _countNumber = 0;
    
    IEnumerator Counting() {
        while (true) {
            _countNumber = 0;
            yield return new WaitForSeconds(1);
            _countNumber = 1;
            yield return new WaitForSeconds(1);
            _countNumber = 2;
            yield return new WaitForSeconds(1);
            _countNumber = 3;
            yield return new WaitForSeconds(1);
            _countNumber = 4;
            yield return new WaitForSeconds(1);
            _countNumber = 5;
            yield return new WaitForSeconds(1);
        }
    }
}
