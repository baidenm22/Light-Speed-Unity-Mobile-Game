using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    public int Score;
    public int HighScore;
    public Text ScoreText;
    public int Coins;


    public void Start()
    {
        
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        Score = 0;
        Coins = PlayerPrefs.GetInt("Coins", 0);
       
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Coins", Coins);
        PlayerPrefs.SetInt("HighScore", HighScore);
        PlayerPrefs.Save();


    }
    public void Update()
    {
       
        ScoreText.text = ""+(Score);
    }






}
