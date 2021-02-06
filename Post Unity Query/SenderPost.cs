using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderPost : MonoBehaviour {
    public delegate void Callback(string content);
    
    private string urlString = "";
    private string bodyString = "";
    private Callback callback = null;

    public void QueryPost(string urlStringParam, string bodyStringParam, Callback callbackParam) {
        urlString = urlStringParam;
        bodyString = bodyStringParam;
        callback = callbackParam;
        StartCoroutine(LoadingPostIEnumerator());
    }

    IEnumerator LoadingPostIEnumerator() {
        Hashtable postHeader = new Hashtable();
        postHeader.Add("Content-Type", "application/json");
        /////////
        var formData = System.Text.Encoding.UTF8.GetBytes(bodyString);
        /////////
        WWW www = new WWW(urlString, formData, postHeader);
        yield return www;
        callback(www.text);
    }
}
