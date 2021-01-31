using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGetSender : MonoBehaviour {
    public delegate void Callback(string content);

    private string urlString = "";
    private Callback callback = null;
    
    public void QueryGet(string urlStringParam, Callback callbackParam) {
        urlString = urlStringParam;
        callback = callbackParam;
        StartCoroutine(QueryGetIEnumerator());
    }

    IEnumerator QueryGetIEnumerator() {
        WWW www = new WWW(urlString);
        yield return www;
        callback(www.text);
    }
}
