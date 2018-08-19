using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

    [Header("Results References")]
    [SerializeField] private GameObject _quizCanvas;
    [SerializeField] private GameObject _resultsCanvas;
    [SerializeField] private Text _resultsText;

    
    [System.Serializable]
    public struct Stat
    {
        public string statName;
        [HideInInspector] public int statValue;
        public string statResultTxt;
    }

    [Header("Stats")]
    public Stat[] _availableStats;

    private void Awake()
    {
    }

    public void AddAnswerPoints(Answer.StatEffect[] statEffects)
    {
        foreach(Answer.StatEffect statEffect in statEffects)
        {
            _availableStats[statEffect.index].statValue += statEffect.valueToAdd;
        }

        foreach(Stat stat in _availableStats)
        {
            Debug.Log(stat.statName + ": " + stat.statValue);
        }
    }

    public void LoadResultScreen()
    {
        _quizCanvas.SetActive(false);
        _resultsCanvas.SetActive(true);

        _resultsText = GameObject.FindGameObjectWithTag("ResultsText").GetComponent<Text>();

        Stat topStat = CalculateTopStat();

        _resultsText.text = topStat.statResultTxt;
    }

    private Stat CalculateTopStat()
    {
        Stat topStat = _availableStats[0];

        foreach(Stat stat in _availableStats)
        {
            if(topStat.statValue < stat.statValue)
                topStat = stat;
        }

        return topStat;
    }
}
