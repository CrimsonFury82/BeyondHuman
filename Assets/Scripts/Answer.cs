using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer {

    [SerializeField] private string name = "Answer";

    [Header("Answer Text")]
    [SerializeField] private string _answerText;

    [Header("Stat Points")]
    [SerializeField] private QuestionManager.Stat[] _statEffectOrder;
    [SerializeField] private int[] _statPointsByOrder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
