using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer {

    [HideInInspector] [SerializeField] private string name = "Answer";

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

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
