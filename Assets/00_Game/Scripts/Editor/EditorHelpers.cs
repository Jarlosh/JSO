using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace NagaiTools.JSO
{
    public static class EditorHelpers
    {
        public static IEnumerable<SerializedProperty> ListProps(SerializedObject serializedObject, 
            bool ignoreScript=true)
        {
            var prop = serializedObject.GetIterator();
            if (prop.NextVisible(true))
            {
                do
                {
                    if (prop.name == "m_Script") continue;
                    var subProp = serializedObject.FindProperty(prop.name);
                    yield return subProp;
                } 
                while (prop.NextVisible(false));
            }
        }
        
        public static Type GetFieldType(FieldInfo fieldInfo)
        {
            Type type = fieldInfo.FieldType;
            if (type.IsArray) type = type.GetElementType();
            else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
                type = type.GetGenericArguments()[0];
            return type;
        }
    }
}