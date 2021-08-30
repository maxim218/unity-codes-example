using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour {
    [SerializeField] private InventoryElement [] arr = null;

    public InventoryElement GetByKey(string key) {
        if (arr == null) return default;
        
        if (arr.Length == 0) return default;
        
        foreach (InventoryElement element in arr) {
            if (key == element.elementScript.elementKey) return element;
        }
        
        return default;
    }

    public void IncCountByKey(string key) {
        for (int i = 0; i < arr.Length; i++) {
            if (key == arr[i].elementScript.elementKey) {
                arr[i].count += 1;
            }
        }
    }
}
