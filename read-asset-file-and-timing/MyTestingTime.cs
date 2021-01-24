using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class MyTestingTime : MonoBehaviour {
    private bool _flag = false;
    
    void OnGUI () {
        if(GUI.Button(new Rect(40, 40,200,100),"Change time")) {
            _flag = !_flag;
            if(_flag)
                Time.timeScale = 0.5f;
            else 
                Time.timeScale = 1;
        }

        string updateString = "Update: " + _countUpdate;
        string fixedUpdateString = "FixedUpdate: " + _coundFixedUpdate;
        string message = "\n\n" + updateString + "\n\n" + fixedUpdateString;
        GUI.Box(new Rect(260,40,300,100), message);
        
        // string from file
        GUI.Box(new Rect(600,40,300,100), "\n\n" + _contentFromFile);
    }

    public GameObject movingHeroObject = null;
    
    void Update() {
        // move hero
        float speedMove = 5.0f;
        movingHeroObject.transform.Translate(0, 0, speedMove * Time.deltaTime);
        // counter
        _countUpdate++;
    }
    
    private int _countUpdate = 0;
    private int _coundFixedUpdate = 0;

    void FixedUpdate() {
        // counter
        _coundFixedUpdate++;
    }

    private string _contentFromFile = "";
    
    void Start() {
        // way to file: Assets/Resources/myFile.txt
        TextAsset asset = Resources.Load<TextAsset>("myFile");
        _contentFromFile = asset.text;
    }
}
