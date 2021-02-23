using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsControlScript : MonoBehaviour {
    void OnGUI() {
        if (GUI.Button(new Rect(50, 50, 50, 50), "A")) MySendToBrowser('A');
        if (GUI.Button(new Rect(150, 50, 50, 50), "B")) MySendToBrowser('B');
        if (GUI.Button(new Rect(250, 50, 50, 50), "C")) MySendToBrowser('C');
    }

    void MySendToBrowser(char c) {
        string functionString = "myJavaScriptFunc";
        string messageString = "aaa_" + c + "_bbb";
        Application.ExternalCall(functionString, messageString);
    }
}
