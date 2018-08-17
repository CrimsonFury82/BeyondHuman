using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour {

    [System.Serializable]
    public struct Stat
    {
        public string statName;
        public int statValue;
    }

    public Stat[] _availableStats;

    

}
