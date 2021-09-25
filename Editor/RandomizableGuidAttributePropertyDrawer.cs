using UnityEditor;
using UnityEngine;

namespace RandomizableFields.Editor
{
    [CustomPropertyDrawer(typeof(RandomizableGuidAttribute))]
    public class RandomizableGuidAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            RandomizableEditorGUI.DrawRandomizableGuidField((RandomizableGuidAttribute) attribute, position, property, label);
        }
    }
}