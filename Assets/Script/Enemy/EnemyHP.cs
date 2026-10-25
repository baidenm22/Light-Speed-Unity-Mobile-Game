using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {


    public int HP;
    public GameObject Self;
    public GameObject GameManger;
    public GameObject AlienKeeper;



    private void Start()
    {
        GameManger = GameObject.FindGameObjectWithTag("Score");
        if (AlienKeeper.GetComponent<SpawnAstroid>().Level >= 60)
        {
            HP = 15; 
        }
    }

    public void Update()
    {
        if (HP == 0)
        {
            
        }



        if (HP <= 0)
        {
            SA();
            GameManger.GetComponent<Scoring>().Score += 15;
            
            Destroy(Self);
        }
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.tag == "PBullet")
        {
            HP -= 1;
            
        }
    }
    public void SA()
    {
        AlienKeeper.GetComponent<ASK>().IsAlien = false;
    }
}
