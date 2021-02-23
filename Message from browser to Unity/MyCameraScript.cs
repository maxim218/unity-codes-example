using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraScript : MonoBehaviour {
    private GameObject _k1;
    private GameObject _k2;
    private GameObject _k3;
    
    void Start() {
        // get objects
        _k1 = GameObject.Find("K1");
        _k2 = GameObject.Find("K2");
        _k3 = GameObject.Find("K3");
        // set color to every object
        ColorSet(_k1, Color.red);
        ColorSet(_k2, Color.red);
        ColorSet(_k3, Color.red);
    }

    void ColorSet(GameObject obj, Color color) {
        Renderer rendererComponent = obj.GetComponent<Renderer>();
        if(rendererComponent) rendererComponent.material.color = color;
    }

    void MakeAllRed() {
        ColorSet(_k1, Color.red);
        ColorSet(_k2, Color.red);
        ColorSet(_k3, Color.red);
    }

    public void FuncForBrowser(string message) {
        if (message.Length == 0) return;
        string [] arr = message.Split('_');
        if (arr.Length != 3) return;
        if (arr[0] != "xxx") return;
        if (arr[2] != "yyy") return;
        string value = arr[1];
        ///////////////////////////////////
        MakeAllRed();
        if(value == "1") ColorSet(_k1, Color.green);
        if(value == "2") ColorSet(_k2, Color.green);
        if(value == "3") ColorSet(_k3, Color.green);
    }
}
