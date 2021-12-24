using System;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

namespace RandomizableFields.Editor
{
    public static class RandomizableEditorGUI
    {
        public static void DrawAsInt(RandomizableAttribute randomizableAttribute, Rect position, SerializedProperty property, GUIContent label)
        {
            DrawPropertyField(ref position, property, label);
            
            if (GUI.Button(position, "R"))
            {
                EditorGUI.FocusTextInControl(null);
                property.intValue = Mathf.RoundToInt(GetNextRandomNumericValue(randomizableAttribute));
            }
        }

        public static void DrawRandomizableFloatField(RandomizableAttribute randomizableAttribute, Rect position, SerializedProperty property, GUIContent label)
        {
            DrawPropertyField(ref position, property, label);

            if (GUI.Button(position, "R"))
            {
                EditorGUI.FocusTextInControl(null);
                property.floatValue = GetNextRandomNumericValue(randomizableAttribute);
            }
        }

        public static void DrawRandomizableGuidField(RandomizableGuidAttribute randomizableGuidAttribute, Rect position, SerializedProperty property, GUIContent label)
        {
            DrawPropertyField(ref position, property, label);

            if (GUI.Button(position, "R"))
            {
                EditorGUI.FocusTextInControl(null);
                property.stringValue = Guid.NewGuid().ToString();
            }
        }

        private static void DrawPropertyField(ref Rect position, SerializedProperty property, GUIContent label)
        {
            position.width -= 30;
            EditorGUI.PropertyField(position, property, label);
            position.x += position.width + 5;
            position.width = 25;
        }

        private static float GetNextRandomNumericValue(RandomizableAttribute randomizableAttribute)
        {
            return Random.Range(randomizableAttribute.min, randomizableAttribute.max);
        }
    }
}