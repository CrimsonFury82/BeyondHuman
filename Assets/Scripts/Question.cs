using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question {

    [Header("Specific Question Settings")]
    [SerializeField] public string _questionName;

    [Header("Relative Answer Settings")]
    public Answer[] _answers;
	
}
