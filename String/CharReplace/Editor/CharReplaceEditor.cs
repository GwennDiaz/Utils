using UnityEditor;
using UnityEngine;

namespace Com.GwennDiaz.Utils.Replace.Editor
{
    [CustomEditor(typeof(CharReplace))]
    public class CharReplaceEditor : UnityEditor.Editor
    {
        SerializedProperty oldChar;
        SerializedProperty newChar;
        private void OnEnable()
        {
            oldChar = serializedObject.FindProperty("oldChar");
            newChar = serializedObject.FindProperty("newChar");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(oldChar);
            EditorGUILayout.PropertyField(newChar);
            serializedObject.ApplyModifiedProperties();
            if(GUILayout.Button("Invert Old And New"))
            {
                string oldChar = this.oldChar.stringValue;
                string newChar = this.newChar.stringValue;

                this.oldChar.stringValue = newChar;
                this.newChar.stringValue = oldChar;
                
                serializedObject.ApplyModifiedProperties();
            }
        }
    }
}
