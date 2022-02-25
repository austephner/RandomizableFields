#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;

namespace RandomizableFields.Editor
{
    [CustomPropertyDrawer(typeof(RandomizableAttribute))]
    public class RandomizableAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var randomizableAttribute = (RandomizableAttribute)attribute;
            var typeCode = Type.GetTypeCode(fieldInfo.FieldType);

            switch (typeCode)
            {
                case TypeCode.Single:
                    RandomizableEditorGUI.DrawRandomizableFloatField(randomizableAttribute, position, property, label);
                    break;
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    RandomizableEditorGUI.DrawAsInt(randomizableAttribute, position, property, label);
                    break;
                default:
                    GUI.Label(position, new GUIContent("Type Not Supported"));
                    return;
            }
        }

        
    }
}
#endif