using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationsControl : MonoBehaviour {
    private MoveHero _scriptHeroObjA;
    private MoveHero _scriptHeroObjB;
    private bool _btnClickedFlag = false;
    
    void Start() {
        _scriptHeroObjA = GameObject.Find("heroA").GetComponent<MoveHero>();
        _scriptHeroObjB = GameObject.Find("heroB").GetComponent<MoveHero>();
    }
    
    void OnGUI () {
        if (_btnClickedFlag) return;
        //////
        if(GUI.Button(new Rect(25, 25, 200, 60),"Запуск")) {
            Debug.Log("Button Click");
            _scriptHeroObjA.AllowMove();
            _scriptHeroObjB.AllowMove();
            _btnClickedFlag = true;
        }
    }
}
