using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryRender : MonoBehaviour {
    private InventoryControl _inventoryControl = null;

    private void Start() {
        _inventoryControl = GetComponent<InventoryControl>();
    }

    [SerializeField] private string [] arrayKeys = null;
    
    private void OnGUI() {
        if (arrayKeys == null) return;

        if (arrayKeys.Length == 0) return;

        for (int i = 0; i < arrayKeys.Length; i++) {
            int index = i;
            string key = arrayKeys[index];
            InventoryElement element = _inventoryControl.GetByKey(key);
            
            GUI.Box(GetRect(index, 50, 75), GetContent(element));
            GUI.Box(GetRect(index, 150, 220), element.elementScript.elementSprite.texture);

            if (GUI.Button(GetRect(index, 400, 30), "Inc " + key)) {
                _inventoryControl.IncCountByKey(key);
            }
        }
    }

    private static Rect GetRect(int index, int y, int height) {
        int x = 50 + 220 * index;
        const int width = 200;
        return new Rect(x, y, width, height);
    }

    private static string GetContent(InventoryElement element) {
        string elementKey = element.elementScript.elementKey;
        string elementInfo = element.elementScript.elementInfo;
        int count = element.count;
        return elementKey + "\n" + elementInfo + "\n" + "\n" + count + "\n";
    }
}
