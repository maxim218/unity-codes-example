using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Student {
    public string login;
    public int age;
    public int[] marks;
}

public class BtnActControl : MonoBehaviour {
    private string _fieldJsonString;
    
    void Start() {
        Student student = new Student();
        //////
        student.login = "Maxim";
        student.age = 18;
        student.marks = new int[5];
        //////
        student.marks[0] = 90;
        student.marks[1] = 80;
        student.marks[2] = 70;
        student.marks[3] = 60;
        student.marks[4] = 50;
        //////
        string jsonString = JsonUtility.ToJson(student);
        Debug.Log(jsonString);
        _fieldJsonString = jsonString;
    }

    void OnGUI() {
        if (GUI.Button(new Rect(50, 30, 200, 40), "Отправить POST запрос")) SendInfoToServerPost();
    }

    void SendInfoToServerPost() {
        SenderPost script = gameObject.GetComponent<SenderPost>();
        //////////////
        string urlString = "http://localhost:5000/query/post";
        string bodyString = _fieldJsonString;
        //////////////
        script.QueryPost(urlString, bodyString, delegate(string answerString) {
            Debug.Log(answerString);
        });
    }
}
