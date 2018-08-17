using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

    [System.Serializable]
    public struct Stat
    {
        public string statName;
        [HideInInspector] public int statValue;
        public string statResultTxt;
    }

    public Stat[] _availableStats;

    [SerializeField] private Text _resultText;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //_resultText = GameObject.FindGameObjectWithTag("ResultsText").GetComponent<Text>();

        //Stat topStat = CalculateTopStat();

        //_resultText.text = topStat.statResultTxt;
    }

    private void OnLevelWasLoaded(int level)
    {
        if(level == 2)
        {
            _resultText = GameObject.FindGameObjectWithTag("ResultsText").GetComponent<Text>();

            Stat topStat = CalculateTopStat();

            _resultText.text = topStat.statResultTxt;
        }
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
