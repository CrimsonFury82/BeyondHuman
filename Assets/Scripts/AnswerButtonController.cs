using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtonController : MonoBehaviour
{
    [HideInInspector] public int _answerIndex;
    [HideInInspector] public QuestionManager _questionManager;

    public void PassAnswer()
    {
        _questionManager.LockInAnswer(_answerIndex);
    }
}
