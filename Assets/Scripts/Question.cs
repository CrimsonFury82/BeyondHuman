using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question {

    [SerializeField] private string name = "Question";

    [Header("Specific Question Settings")]
    [SerializeField] private string _questionName;

    [Header("Relative Answer Settings")]
    public Answer[] _answers;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
