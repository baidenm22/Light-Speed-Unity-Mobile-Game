using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour {

    public GameObject Self;


    public GameObject Spawner;
    public GameObject Menu;
    public Text Score;
    public Text HighScore;
    public Text CoinsText;
    public GameObject Astroid;
    public GameObject GameManger;
    public float HitCoolDown;
    public GameObject[] Bullets;
    public GameObject[] EBullets;
    public GameObject EShips;
    public Image HitMark;

    private void Start()
    {
        if (PlayerPrefs.GetInt("GU1") == 1)
        {
            Self.GetComponent<PowerUps>().ExtraLife += 1;
        }
        if (PlayerPrefs.GetInt("GU2") == 1)
        {
            Self.GetComponent<PowerUps>().ExtraLife += 1;
        }
        


    }

    private void Update()
    {
        if (HitCoolDown > 0)
        {
            HitCoolDown -= Time.deltaTime;
        }
        Bullets = GameObject.FindGameObjectsWithTag("PBullet");
        EBullets = GameObject.FindGameObjectsWithTag("ESHOT");

        EShips = GameObject.FindGameObjectWithTag("Alien");
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ESHOT" || collision.gameObject.tag == "EBullet" || collision.gameObject.tag == "SEBUllet")
        {
            if (HitCoolDown <= 0)
            {
                if (Self.GetComponent<PowerUps>().ExtraLife <= 0)
                {
                    if (GameManger.GetComponent<Scoring>().HighScore < GameManger.GetComponent<Scoring>().Score)
                    {
                        GameManger.GetComponent<Scoring>().HighScore = GameManger.GetComponent<Scoring>().Score;

                    }





                    Score.text = "Score: " + GameManger.GetComponent<Scoring>().Score;
                    HighScore.text = "Highscore: " + GameManger.GetComponent<Scoring>().HighScore;
                    GameManger.GetComponent<Scoring>().Coins += Mathf.RoundToInt(GameManger.GetComponent<Scoring>().Score / 10);
                    CoinsText.text = "" + GameManger.GetComponent<Scoring>().Coins;
                    GameManger.GetComponent<Scoring>().Score = 0;


                    GameManger.GetComponent<Scoring>().Save();


                    Astroid.GetComponent<Astroid>().MovementSpeed = 5;
                    Destroy(Self);
                    Spawner.GetComponent<SpawnAstroid>().enabled = false;
                    Menu.SetActive(true);
                    Destroy(EShips);
                    for (int i = 0; i < Bullets.Length; i++)
                    {
                        Destroy(Bullets[i]);
                    }
                    for (int i = 0; i < EBullets.Length; i++)
                    {
                        Destroy(EBullets[i]);
                    }




                }
                else
                {
                    Destroy(collision.gameObject);
                    HitCoolDown = .5f;
                    Self.GetComponent<PowerUps>().ExtraLife -= 1;
                }


                StartCoroutine(HitInd());

            }
        }

    }

    IEnumerator HitInd()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().SetTrigger("SmallScreenShake");
        HitMark.enabled = true;
        yield return new WaitForSeconds(.4f);
        HitMark.enabled = false;


    }
  
}
