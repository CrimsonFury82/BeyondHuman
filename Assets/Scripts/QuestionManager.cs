using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour {

    public enum Stat { AGRESSION, STAT_A, STAT_B}

    [Header("Questions")]
    [SerializeField] private Question[] _questions;

    [Header("Question References")]
    [SerializeField] private Text _questionText;
    [SerializeField] private Text _questionNumberText;

    [Header("Answer References")]
    [SerializeField] private GameObject _answerPanel;
    [SerializeField] private GameObject _answerPrefab;

    private Question _selectedQuestion;
    private Answer[] _selectedAnswers;
    private int _selectedQuestionIndex = -1;
    private int _questionAmount;

	// Use this for initialization
	private void Start ()
    {
        // Setup.
        _selectedQuestionIndex = -1;
        InitialiseNextQuestion();
    }
	
	// Update is called once per frame
	private void Update ()
    {
		
	}

    private void InitialiseNextQuestion()
    {
        _selectedQuestionIndex++;
        _selectedQuestion = _questions[_selectedQuestionIndex];
        _selectedAnswers = _selectedQuestion._answers;

        UpdateUI();
    }

    private void UpdateUI()
    {
        // Question Text.
        _questionNumberText.text = "Question " + (_selectedQuestionIndex + 1) + " of " + _questionAmount;
        _questionText.text = _selectedQuestion._questionName;

        // Answers.
        for(int index = 0; index < _selectedAnswers.Length; index++)
        {
            // Initialisation of an Answer.
            Answer answer = _selectedAnswers[index];
            GameObject answerButton = Instantiate(_answerPrefab, _answerPanel.transform);

            // Setting UI Text.
            Text answerText = answerButton.GetComponentInChildren<Text>();
            answerText.text = answer._answerTxt;

            // Setting Controller Values.
            AnswerButtonController controller = answerButton.GetComponent<AnswerButtonController>();
            controller._answerIndex = index;
            controller._questionManager = this;
        }
    }

    public void LockInAnswer(int answerIndex)
    {
        Debug.Log(_selectedAnswers[answerIndex]._answerTxt);
    }
}
