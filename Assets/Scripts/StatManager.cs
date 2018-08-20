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
    [SerializeField] private Image resultsImage; //added by Aston

    [System.Serializable]
    public struct Stat
    {
        public string statName;
        [HideInInspector] public int statValue;
        public string statResultTxt;
        public Sprite resultsSprite; //added by Aston
    }

    [Header("Stats")]
    public Stat[] _availableStats;

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
        resultsImage = GameObject.FindGameObjectWithTag("ResultsImage").GetComponent<Image>(); //added by Aston

        Stat topStat = CalculateTopStat();

        _resultsText.text = topStat.statResultTxt;
        resultsImage.sprite = topStat.resultsSprite; //added by Aston
    }

    private Stat CalculateTopStat()
    {
        Stat topStat = _availableStats[0];

        foreach (Stat stat in _availableStats)
        {
            if(topStat.statValue < stat.statValue)
                topStat = stat;
        }
        return topStat;
    }

}
