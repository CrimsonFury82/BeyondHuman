using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour {

    public enum Stat { AGRESSION, STAT_A, STAT_B}

    [Header("Questions")]
    public Question[] _questions;

    [Header("Question References")]
    public GameObject _questionText;

    [Header("Answer References")]
    public GameObject _answerPanel;
    public GameObject _answerPrefab;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
