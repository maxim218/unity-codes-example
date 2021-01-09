using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ImgType {
    A,
    B,
    C
}

public class CardControl : MonoBehaviour {
    [SerializeField] private Sprite cardA = null;
    [SerializeField] private Sprite cardB = null;
    [SerializeField] private Sprite cardC = null;

    [SerializeField] private ImgType type;

    void OnMouseDown() {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if(type == ImgType.A) spriteRenderer.sprite = cardA;
        if(type == ImgType.B) spriteRenderer.sprite = cardB;
        if(type == ImgType.C) spriteRenderer.sprite = cardC;
    }
}
