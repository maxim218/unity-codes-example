using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "ElementData", menuName = "MyAssetMenu/ElementData")]
public class ElementScript : ScriptableObject {
    public string elementKey = string.Empty;
    public Sprite elementSprite = null;
    public string elementInfo = string.Empty;
}
