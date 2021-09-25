using UnityEditor;
using UnityEngine;

namespace RandomizableIntFields.Editor
{
    [CustomPropertyDrawer(typeof(RandomizableAttribute))]
    public class RandomizableAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var randomizableAttribute = (RandomizableAttribute)attribute;

            if (fieldInfo.FieldType.IsGenericType)
            {
                position.width -= 30;
                EditorGUI.PropertyField(position, property, label);
            }
            else
            {
                // todo: show warning icon
                GUI.Label(position, new GUIContent("Type Not Supported"));
                return;
            }

            position.x += position.width + 5;
            position.width = 25;

            if (GUI.Button(position, "R"))
            {
                var genericType = fieldInfo.FieldType.GetGenericTypeDefinition();

                if (genericType == typeof(float))
                {
                    property.floatValue = Random.Range(randomizableAttribute.min, randomizableAttribute.max);
                }
                else if (genericType == typeof(int)) 
                {
                    property.intValue = Mathf.RoundToInt(Random.Range(randomizableAttribute.min, randomizableAttribute.max));
                }
            }
        }
    }
}