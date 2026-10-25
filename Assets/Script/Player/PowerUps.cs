using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {


    public int ExtraLife;
    public bool DoubleShoot;
    public int Pericing;

    public float TimerDS;
    public float TimerP;

    public Text TextHealth;
    public Text TextRed;
    public Text TextPurple;

    public int RU1;
    public int PU1;

    private void Start()
    {
        if (PlayerPrefs.GetInt("RU1") == 1)
        {
            RU1 += 5;

        }
        if (PlayerPrefs.GetInt("RU2") == 1)
        {
            RU1 += 5;
        }
        TimerDS += RU1;
        if (PlayerPrefs.GetInt("PU1") == 1)
        {
            PU1 += 5;

        }
        if (PlayerPrefs.GetInt("PU2") == 1)
        {
            PU1 += 5;

        }
        TimerP += PU1;

    }





    void Update()
    {

        TextHealth.text = "X " + (ExtraLife);



        if (DoubleShoot == true)
        {
            TimerDS -= Time.deltaTime;
            TextRed.text = (Mathf.RoundToInt(TimerDS).ToString());
        }
        if (Pericing >= 1)
        {
            TimerP -= Time.deltaTime;
            TextPurple.text = (Mathf.RoundToInt(TimerP).ToString());
        }
        if (TimerP <= 0)
        {
            TextPurple.text = (0.ToString());
            Pericing = 0;
            TimerP = 15 + PU1;
        }
        if (TimerDS <= 0)
        {
            TextRed.text = (0.ToString());
            DoubleShoot = false;
            TimerDS = 15 + RU1;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HU")
        {
            ExtraLife++;
            int CEL = Mathf.RoundToInt(Random.Range(0, 2));
            if (CEL == 1 && PlayerPrefs.GetInt("GU3") == 1)
            {
                ExtraLife++;
            } 
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DSU")
        {
            TimerDS = 15 + RU1;
            DoubleShoot = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PU")
        {
            TimerP = 15 + PU1;
            Pericing = 1;
            Destroy(collision.gameObject);
        }



    }





}
