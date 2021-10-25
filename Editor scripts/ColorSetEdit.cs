using System;
using UnityEngine;
using UnityEditor;

namespace Editor
{
    [CustomEditor(typeof(GameObject))]
    public class ColorSetEdit : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUILayout.BeginHorizontal();
              if (GUILayout.Button("Red")) SetColor(Color.red);
              if (GUILayout.Button("Green")) SetColor(Color.green);
              if (GUILayout.Button("Blue")) SetColor(Color.blue);
            GUILayout.EndHorizontal();
        }

        private void SetColor(Color color)
        {
            GameObject me = (GameObject) target;
            Renderer comp = me.GetComponent<Renderer>();
            comp.sharedMaterial.color = color;
        }
    }
}
