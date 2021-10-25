using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class ScaleWindow : EditorWindow
    {
        [MenuItem("Window/My Helping Windows/Scale Window")]
        public static void ShowWindow()
        {
            const string title = "Scale Window";
            GetWindow<ScaleWindow>(title);
        }

        private Object _elementObj = null;
        private int _intScale = 1;
        
        private void OnGUI()
        {
            // label
            GUILayout.Label("Масштабирование элемента", EditorStyles.boldLabel);
            
            // object field
            _elementObj = EditorGUILayout.ObjectField("Элемент", _elementObj, typeof(Object), true);
            
            // int field
            _intScale = EditorGUILayout.IntField("Масштаб", _intScale);

            // button
            if (GUILayout.Button("Применить масштаб")) SetElementScale();
        }

        private void SetElementScale()
        {
            if (!_elementObj) return;
            GameObject obj = (GameObject) _elementObj;
            obj.transform.localScale = new Vector3(_intScale, _intScale, _intScale);
        }
    }
}
