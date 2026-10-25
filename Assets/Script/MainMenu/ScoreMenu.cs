using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{

    public int Score;
    public int HighScore;
    public Text CoinText;
    public Text HighScoreText;
    //public Text ScoreText;
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
        Coins = PlayerPrefs.GetInt("Coins", 0);
        //ScoreText.text = "" + (Score);
        HighScoreText.text = "HI: " + (HighScore);
        CoinText.text = "" + (Coins);
    }






}
