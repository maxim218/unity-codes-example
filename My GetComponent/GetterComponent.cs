using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetterComponent {
    public static T GetComp <T> (GameObject obj) {
        T comp = obj.GetComponent<T>();
        return comp;
    }
}
