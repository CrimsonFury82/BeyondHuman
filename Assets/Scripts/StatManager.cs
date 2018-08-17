using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour {

    [System.Serializable]
    public struct Stat
    {
        public string statName;
        [HideInInspector] public int statValue;
    }

    public Stat[] _availableStats;

    public void AddAnswerPoints(Answer.StatEffect[] statEffects)
    {
        foreach(Answer.StatEffect statEffect in statEffects)
        {
            _availableStats[statEffect.index].statValue += statEffect.valueToAdd;
        }

        foreach(Stat stat in _availableStats)
        {
            Debug.Log(stat.statName + ": " + stat.statValue);
        }
    }
}
