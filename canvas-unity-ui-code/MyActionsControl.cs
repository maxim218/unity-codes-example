using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
     I added component "Event Trigger" to "Close Button"
     Component "Event Trigger" helps to add event on image and make it works like btn
 */

public class MyActionsControl : MonoBehaviour {
    private Text _ttt = null;
    private Text _rrr = null;
    private Text _bbb = null;
    
    [SerializeField] private Sprite cardA = null;
    [SerializeField] private Sprite cardB = null;
    [SerializeField] private GameObject closeBtn = null;

    public void Start() {
        Debug.Log("Start on Camera");
        _ttt = GameObject.Find("FieldInput").transform.Find("Text").gameObject.GetComponent<Text>();
        _rrr = GameObject.Find("BulletsText").GetComponent<Text>();
        _bbb = GameObject.Find("BtnHelp").transform.Find("Text").gameObject.GetComponent<Text>();
        TextColorSet(_bbb, 250.0f, 0, 0);
    }
    
    public void MenuBtnClickFunc() {
        string content = _ttt.text + "";
        Debug.Log("Text: " + content + "  Length: " + content.Length);
        _rrr.text = content;
    }

    private void TextColorSet(Text linkText, float r, float g, float b) {
        var rColor = r / 255f;
        var gColor = g / 255f;
        var bColor = b / 255f;
        linkText.color = new Color(rColor, gColor, bColor);
    }

    public void BtnEnterP() {
        TextColorSet(_bbb, 250.0f, 250.0f, 250.0f);
    }

    public void BtnExitP() {
        TextColorSet(_bbb, 250.0f, 0, 0);
    }

    public void CloseImageEnter() {
        Image image = closeBtn.GetComponent<Image>();
        image.sprite = cardB;
    }

    public void CloseImageExit() {
        Image image = closeBtn.GetComponent<Image>();
        image.sprite = cardA;
    }

    public void CloseImageMouseClkFunc() {
        Debug.Log("Close btn click");
        _rrr.text = "Close =)";
    }
}
