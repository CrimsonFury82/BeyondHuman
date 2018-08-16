﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer {

    [SerializeField] private string name = "Answer";

    [Header("Answer Text")]
    [SerializeField] public string _answerTxt;

    [Header("Stat Points")]
    [SerializeField] private StatManager.Stat[] _statEffectOrder;
    [SerializeField] private int[] _statPointsByOrder;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
