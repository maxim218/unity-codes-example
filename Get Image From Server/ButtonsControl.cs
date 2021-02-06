using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsControl : MonoBehaviour {
    public GameObject planeObject = null;
    
    void GetImageAndSetTexture(char paramChar) {
        string urlString = "http://localhost:5000/get/image/content?p=" + paramChar;
        GetImage script = gameObject.GetComponent<GetImage>();
        script.ImageMyGet(urlString, delegate(Texture2D answerTexture) {
            planeObject.GetComponent<Renderer>().material.mainTexture = answerTexture;
            planeObject.GetComponent<Renderer>().material.color = Color.white;
        });
    }
    
    void OnGUI() {
        if (GUI.Button(new Rect(50, 30, 100, 40), "Picture A")) GetImageAndSetTexture('A');
        if (GUI.Button(new Rect(170, 30, 100, 40), "Picture B")) GetImageAndSetTexture('B');
        if (GUI.Button(new Rect(290, 30, 100, 40), "Picture C")) GetImageAndSetTexture('C');
    }
}
