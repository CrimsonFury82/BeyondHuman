using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(StatEffectAttribute))]
public class EAnswer : PropertyDrawer
{
    private StatManager _currentStatManager;

    private int _selectedIndex;

    private string[] _options;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        _currentStatManager = ((StatEffectAttribute)attribute)._statManager as StatManager;

        int statAmount = _currentStatManager._availableStats.Length;

        _options = new string[statAmount];

        for(int index = 0; index < _currentStatManager._availableStats.Length; index++)
        {
            _options[index] = _currentStatManager._availableStats[index].statName;
        }

        property.intValue = EditorGUI.Popup(position, "GUITest", property.intValue, _options);

        //if(EditorGUI.EndChangeCheck())
        //    property.intValue = _selectedIndex;
    }
}