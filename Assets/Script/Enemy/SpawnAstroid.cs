using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAstroid : MonoBehaviour {

    public GameObject Astroid;
    
    public GameObject[] SpawnPoints;

    public float Timer;
    private float GoOnTimer;
    public int Level;
    public float Diff;

    public GameObject GameManger;
    public float WhatEvent;


    

    public void SpawnOnAll()
    {
        //Spawn on all Spawnpoints
       for (int i = 0; i < 9; i++)
        {
            Instantiate(Astroid, SpawnPoints[i].transform.position, Quaternion.identity);
        }
    
    }
    public void SpawnRandom5()
    {
        //Random Numbers
        int WhatSpawn1 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn2 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn3 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn4 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn5 = Mathf.RoundToInt(Random.Range(0, 9));


        //Determine if the they have the smae number
        if (WhatSpawn1 != WhatSpawn2 && WhatSpawn1 != WhatSpawn3 && WhatSpawn1 != WhatSpawn4 && WhatSpawn1 != WhatSpawn5)
        {

        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                WhatSpawn1 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn1 != WhatSpawn2 && WhatSpawn1 != WhatSpawn3 && WhatSpawn1 != WhatSpawn4 && WhatSpawn1 != WhatSpawn5)
                {
                    break;
                }
            }
        }
        if (WhatSpawn2 != WhatSpawn1 && WhatSpawn2 != WhatSpawn3 && WhatSpawn2 != WhatSpawn4 && WhatSpawn2 != WhatSpawn5)
        {

        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                WhatSpawn2 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn2 != WhatSpawn1 && WhatSpawn2 != WhatSpawn3 && WhatSpawn2 != WhatSpawn4 && WhatSpawn2 != WhatSpawn5)
                {
                    break;
                }
            }
        }
        if (WhatSpawn3 != WhatSpawn1 && WhatSpawn3 != WhatSpawn2 && WhatSpawn3 != WhatSpawn4 && WhatSpawn3 != WhatSpawn5)
        {

        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                WhatSpawn3 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn3 != WhatSpawn1 && WhatSpawn3 != WhatSpawn2 && WhatSpawn3 != WhatSpawn4 && WhatSpawn3 != WhatSpawn5)
                {
                    break;
                }
            }
        }
        if (WhatSpawn4 != WhatSpawn1 && WhatSpawn4 != WhatSpawn3 && WhatSpawn4 != WhatSpawn2 && WhatSpawn4 != WhatSpawn5)
        {

        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                WhatSpawn4 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn4 != WhatSpawn1 && WhatSpawn4 != WhatSpawn3 && WhatSpawn4 != WhatSpawn2 && WhatSpawn4 != WhatSpawn5)
                {
                    break;
                }
            }
        }
        if (WhatSpawn5 != WhatSpawn1 && WhatSpawn5 != WhatSpawn3 && WhatSpawn5 != WhatSpawn2 && WhatSpawn5 != WhatSpawn4)
        {

        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                WhatSpawn4 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn5 != WhatSpawn1 && WhatSpawn5 != WhatSpawn3 && WhatSpawn5 != WhatSpawn2 && WhatSpawn5 != WhatSpawn4)
                {
                    break;
                }
            }
        }



        Instantiate(Astroid, SpawnPoints[WhatSpawn1].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn2].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn3].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn4].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn5].transform.position, Quaternion.identity);

    }
    public void SpawnRandom4()
    {
        //Random Numbers
        int WhatSpawn1 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn2 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn3 = Mathf.RoundToInt(Random.Range(0, 9));
        int WhatSpawn4 = Mathf.RoundToInt(Random.Range(0, 9));


        //Determine if the they have the smae number
        if (WhatSpawn1 != WhatSpawn2 && WhatSpawn1 != WhatSpawn3 && WhatSpawn1 != WhatSpawn4)
        {

        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                WhatSpawn1 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn1 != WhatSpawn2 && WhatSpawn1 != WhatSpawn3 && WhatSpawn1 != WhatSpawn4)
                {
                    break;
                }
            }
        }
        if (WhatSpawn2 != WhatSpawn1 && WhatSpawn2 != WhatSpawn3 && WhatSpawn2 != WhatSpawn4)
        {
            
        } else
        {
            for (int i = 0; i < 900;i++)
            {
                WhatSpawn2 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn2 != WhatSpawn1 && WhatSpawn2 != WhatSpawn3 && WhatSpawn2 != WhatSpawn4)
                {
                    break;
                }
            }
        }
        if (WhatSpawn3 != WhatSpawn1 && WhatSpawn3 != WhatSpawn2 && WhatSpawn3 != WhatSpawn4)
        {
            
        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                 WhatSpawn3 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn3 != WhatSpawn1 && WhatSpawn3 != WhatSpawn2 && WhatSpawn3 != WhatSpawn4)
                {
                    break;
                }
            }
        }
        if (WhatSpawn4 != WhatSpawn1 && WhatSpawn4 != WhatSpawn3 && WhatSpawn4 != WhatSpawn2)
        {
            
        }
        else
        {
            for (int i = 0; i < 900; i++)
            {
                 WhatSpawn4 = Mathf.RoundToInt(Random.Range(0, 9));
                if (WhatSpawn4 != WhatSpawn1 && WhatSpawn4 != WhatSpawn3 && WhatSpawn4 != WhatSpawn2)
                {
                    break;
                }
            }
        }

        

        Instantiate(Astroid, SpawnPoints[WhatSpawn1].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn2].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn3].transform.position, Quaternion.identity);
        Instantiate(Astroid, SpawnPoints[WhatSpawn4].transform.position, Quaternion.identity);

    }

    

    public void Start()
    {
         SpawnPoints = GameObject.FindGameObjectsWithTag("AstroSpawn");
        GoOnTimer = 2;
    }








    public void Update()
    {
        Timer -= Time.deltaTime;


        if (Timer <= 0)
        {

            
            
            WhatEvent = Mathf.RoundToInt(Random.Range(0, 3));
            Timer = GoOnTimer;
            
            if (WhatEvent == 0)
            {
                SpawnOnAll();
               
            }
            if (WhatEvent == 2)
            {
                SpawnRandom4();
                
            }
            if (WhatEvent == 1)
            {
                SpawnRandom5();
               
            }



            Level++;
            GameManger.GetComponent<Scoring>().Score += 10;
        }
        if (Level == 10)
        {
            Astroid.GetComponent<Astroid>().MovementSpeed = 6f;
           
        }
        if (Level == 20)
        {
            Astroid.GetComponent<Astroid>().MovementSpeed = 7f;
            GoOnTimer = 1.75f;
        }
        if (Level == 30)
        {
            Astroid.GetComponent<Astroid>().MovementSpeed = 8f;
        }
        if (Level == 40)
        {
            Astroid.GetComponent<Astroid>().MovementSpeed = 9f;
            GoOnTimer = 1.5f;
        }
        if (Level == 50)
        {
            Astroid.GetComponent<Astroid>().MovementSpeed = 10f;
        }
        if (Level == 60)
        {
            Astroid.GetComponent<Astroid>().MovementSpeed = 11f;
            GoOnTimer = 1f;
        }



    }



}
