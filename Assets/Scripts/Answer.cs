using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer {

    [Header("Answer Text")]
    [SerializeField] public string _answerTxt;
    
    [System.Serializable]
    public struct StatEffect
    {
        [StatEffect()]
        public int index;

        public int valueToAdd;
    }

    public StatEffect[] _statEffects;
	
}
