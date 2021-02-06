using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetImage : MonoBehaviour {
    public delegate void Callback(Texture2D content);
    
    private string urlString = "";
    private Callback callback = null;

    public void ImageMyGet(string urlStringParam, Callback callbackParam) {
        urlString = urlStringParam;
        callback = callbackParam;
        StartCoroutine(LoadingImageIEnumerator());
    }

    IEnumerator LoadingImageIEnumerator() {
        WWW www = new WWW(urlString);
        yield return www;
        callback(www.texture);
    }
}
