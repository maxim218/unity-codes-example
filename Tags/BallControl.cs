using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    private static void RedMethod() {
        const string msg = "Red";
        Debug.Log(msg);
    }

    private static void GreenMethod() {
        const string msg = "Green";
        Debug.Log(msg);
    }

    private static void BlueMethod() {
        const string msg = "Blue";
        Debug.Log(msg);
    }
    
    private void OnMouseDown() {
        string myTag = gameObject.tag;
        switch (myTag) {
            case "TagRed": RedMethod(); break;
            case "TagGreen": GreenMethod(); break;
            case "TagBlue": BlueMethod(); break;
        }
    }
}
