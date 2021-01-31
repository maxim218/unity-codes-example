using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGraphics : MonoBehaviour {
    public string contentA = "";
    public string contentB = "";

    void SendGetQuery() {
        MyGetSender myGetSender = gameObject.GetComponent<MyGetSender>();
        /////
        string urlString = "http://localhost:5000/query/get?a=" + contentA + "&b=" + contentB;
        /////
        myGetSender.QueryGet(urlString, delegate(string answerString) {
            Debug.Log("Answer: " + answerString);
        });
    }
    
    void OnGUI() {
        // labels
        GUI.Label(new Rect(35, 30, 90, 30),"Param A");
        GUI.Label(new Rect(35, 80, 90, 30),"Param B");
        
        // read from input fields
        contentA = GUI.TextField(new Rect(140, 30, 150, 30), contentA, 5);
        contentB = GUI.TextField(new Rect(140, 80, 150, 30), contentB, 5);
        
        // button send get
        if (GUI.Button(new Rect(35, 140, 200, 50), "Send query GET")) SendGetQuery();
    }
}
