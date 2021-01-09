using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedCard : MonoBehaviour {
    [SerializeField] private Sprite cardA = null;
    [SerializeField] private Sprite cardB = null;
    [SerializeField] private Sprite cardC = null;

    private int _count = 0;
    
    public void NextImage() {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        /////
        if(_count == 0) spriteRenderer.sprite = cardA;
        if(_count == 1) spriteRenderer.sprite = cardB;
        if(_count == 2) spriteRenderer.sprite = cardC;
        /////
        _count++;
        _count %= 3;
    }
}
