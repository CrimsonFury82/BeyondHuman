using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour {

    [Header("Questions")]
    [SerializeField] private Question[] _questions;

    [Header("Question References")]
    [SerializeField] private Text _questionText;
    [SerializeField] private Text _questionNumberText;

    [Header("Answer References")]
    [SerializeField] private GameObject _answerPanel;
    [SerializeField] private GameObject _answerPrefab;
    private GameObject[] _currentAnswerButtons;

    private Question _selectedQuestion;
    private Answer[] _selectedAnswers;
    private int _selectedQuestionIndex = -1;
    private int _questionAmount;

	// Use this for initialization
	private void Start ()
    {
        // Setup.
        _selectedQuestionIndex = -1;
        _questionAmount = _questions.Length;
        _currentAnswerButtons = new GameObject[0];
        InitialiseNextQuestion();
    }
	
	// Update is called once per frame
	private void Update ()
    {
		
	}

    private void InitialiseNextQuestion()
    {
        if(_currentAnswerButtons.Length > 0)
            RemoveAnswerButtons();

        _selectedQuestionIndex++;

        if(_selectedQuestionIndex >= _questionAmount)
        {
            // Show Results Screen.
            return;
        }

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
        int answersAmount = _selectedAnswers.Length;

        _currentAnswerButtons = new GameObject[answersAmount];

        for(int index = 0; index < answersAmount; index++)
        {
            // Initialisation of an Answer.
            Answer answer = _selectedAnswers[index];
            GameObject answerButton = Instantiate(_answerPrefab, _answerPanel.transform);
            _currentAnswerButtons[index] = answerButton;

            // Setting UI Text.
            Text answerText = answerButton.GetComponentInChildren<Text>();
            answerText.text = answer._answerTxt;

            // Setting Controller Values.
            AnswerButtonController controller = answerButton.GetComponent<AnswerButtonController>();
            controller._answerIndex = index;
            controller._questionManager = this;
        }
    }

    private void RemoveAnswerButtons()
    {
        for(int index = 0; index < _currentAnswerButtons.Length; index++)
        {
            Destroy(_currentAnswerButtons[index]);
        }
    }

    public void LockInAnswer(int answerIndex)
    {
        Debug.Log(_selectedAnswers[answerIndex]._answerTxt);

        InitialiseNextQuestion();
    }
}
