using System;
using UnityEngine;
using UnityEditor;

namespace Editor
{
    public class AlignWindow : EditorWindow
    {
        [MenuItem("Window/My Helping Windows/Align Window")]
        public static void ShowWindow()
        {
            const string title = "Align Window";
            GetWindow<AlignWindow>(title);
        }

        private string _axisString = string.Empty;
        private string _positionString = string.Empty;
        
        private void OnGUI()
        {
            // label
            GUILayout.Label("Выравнивание элементов", EditorStyles.boldLabel);
            
            // text fields
            _axisString = EditorGUILayout.TextField("Ось", _axisString);
            _positionString = EditorGUILayout.TextField("Позиция", _positionString);

            // button
            if (GUILayout.Button("Выровнять элементы")) SetPositionOfSelectedElements();
        }

        private void SetPositionOfSelectedElements()
        {
            float posFloat = float.Parse(_positionString);
            foreach (GameObject obj in Selection.gameObjects)
            {
                Vector3 vectorPosition = obj.transform.position;
                switch (_axisString)
                {
                    case "X": vectorPosition.x = posFloat; break;
                    case "Y": vectorPosition.y = posFloat; break;
                    case "Z": vectorPosition.z = posFloat; break;
                }
                obj.transform.position = vectorPosition;
            }
        }
    }
}
