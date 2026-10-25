using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AstoridHit : MonoBehaviour {


    public int HP;
    public GameObject Self;
    public GameObject SmallMeteor;
    public GameObject GameManger;

    public GameObject Health;
    public GameObject Percing;
    public GameObject Double;
    public Animator CamerA;


    private void Start()
    {
        GameManger = GameObject.FindGameObjectWithTag("Score");
        CamerA = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        
    }


    public void Update()
    {
        if (HP <= 0)
        {

            int PowerUpChance = Mathf.RoundToInt(Random.Range(0, 11));
            if (PlayerPrefs.GetInt("OVU") == 1)
            {
                if (PowerUpChance <= 5)
                {
                    int WhatPowerUp = Mathf.RoundToInt(Random.Range(0, 4));
                    if (WhatPowerUp == 1)
                    {
                        Instantiate(Health, Self.transform.position, Quaternion.identity);

                    }
                    if (WhatPowerUp == 2)
                    {
                        Instantiate(Percing, Self.transform.position, Quaternion.identity);
                    }
                    if (WhatPowerUp == 3)
                    {
                        Instantiate(Double, Self.transform.position, Quaternion.identity);
                    }
                }


            }
            else
            {
                if (PowerUpChance <= 3)
                {
                    int WhatPowerUp = Mathf.RoundToInt(Random.Range(0, 4));
                    if (WhatPowerUp == 1)
                    {
                        Instantiate(Health, Self.transform.position, Quaternion.identity);

                    }
                    if (WhatPowerUp == 2)
                    {
                        Instantiate(Percing, Self.transform.position, Quaternion.identity);
                    }
                    if (WhatPowerUp == 3)
                    {
                        Instantiate(Double, Self.transform.position, Quaternion.identity);
                    }
                }
            }
                 GameManger.GetComponent<Scoring>().Score += 5;
                int HowMany = Mathf.RoundToInt(Random.Range(2, 5));

                if (HowMany >= 4)
                {
                    Instantiate(SmallMeteor, Self.transform.position, Quaternion.identity);
                }
                if (HowMany >= 3)
                {
                    Instantiate(SmallMeteor, Self.transform.position, Quaternion.identity);
                }

                Instantiate(SmallMeteor, Self.transform.position, Quaternion.identity);
                Instantiate(SmallMeteor, Self.transform.position, Quaternion.identity);

            CamerA.SetTrigger("Shake");
                    

                Destroy(Self);
            }

        }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "PBullet")
        {
            HP -= 1;

        }
    }

}
