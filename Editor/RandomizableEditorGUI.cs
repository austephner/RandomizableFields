using UnityEditor;
using UnityEngine;

namespace RandomizableIntFields.Editor
{
    public static class RandomizableEditorGUI
    {
        public static void DrawAsInt(RandomizableAttribute randomizableAttribute, Rect position, SerializedProperty property, GUIContent label)
        {
            DrawPropertyField(ref position, property, label);
            
            if (GUI.Button(position, "R"))
            {
                property.intValue = Mathf.RoundToInt(GetNextRandom(randomizableAttribute));
            }
        }

        public static void DrawRandomizableFloatField(RandomizableAttribute randomizableAttribute, Rect position, SerializedProperty property, GUIContent label)
        {
            DrawPropertyField(ref position, property, label);

            if (GUI.Button(position, "R"))
            {
                property.floatValue = GetNextRandom(randomizableAttribute);
            }
        }

        private static void DrawPropertyField(ref Rect position, SerializedProperty property, GUIContent label)
        {
            position.width -= 30;
            EditorGUI.PropertyField(position, property, label);
            position.x += position.width + 5;
            position.width = 25;
        }

        private static float GetNextRandom(RandomizableAttribute randomizableAttribute)
        {
            return Random.Range(randomizableAttribute.min, randomizableAttribute.max);
        }
    }
}