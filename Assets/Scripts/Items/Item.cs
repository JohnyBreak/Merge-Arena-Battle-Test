using UnityEngine;
using UnityEditor;

public abstract class Item : ScriptableObject
{
    [ScriptableItemId] [SerializeField] private string _id;
    [SerializeField] private string _name;

    public string Name => _name;
    public string ID => _id;
}


#if UNITY_EDITOR

public class ScriptableItemIdAttribute : PropertyAttribute { }

[CustomPropertyDrawer(typeof(ScriptableItemIdAttribute))]
public class ScriptableObjectIdDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = false;

        Object owner = property.serializedObject.targetObject;
        // This is the unity managed GUID of the scriptable object, which is always unique :3
        string unityManagedGuid = AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(owner));

        if (property.stringValue != unityManagedGuid)
        {
            property.stringValue = unityManagedGuid;
        }
        EditorGUI.PropertyField(position, property, label, true);

        GUI.enabled = true;
    }
}
#endif
