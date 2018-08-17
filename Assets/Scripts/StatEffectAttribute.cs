using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StatEffectAttribute : PropertyAttribute
{
    [SerializeField] public int index;
    [SerializeField] public StatManager _statManager;

    public StatEffectAttribute()
    {
        _statManager = GameObject.FindGameObjectWithTag("GameGod").GetComponent<StatManager>();
    }
}
