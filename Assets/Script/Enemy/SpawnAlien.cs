using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAlien : MonoBehaviour {

    public GameObject Alien;
    public GameObject[] Spawnpoints;
    public GameObject Self;
    public GameObject AlienKeeper;
    public float Timer;
    public float SetTimer;
   

    void Start () {
        Spawnpoints = GameObject.FindGameObjectsWithTag("ASpawn");
        AlienKeeper.GetComponent<ASK>().IsAlien = false;
    }
	
	
	void Update () {

       

        if (Self.GetComponent<SpawnAstroid>().Level >= 30)
        {
            if (AlienKeeper.GetComponent<ASK>().IsAlien == false)
            {
                Timer -= Time.deltaTime;
                if (Timer <= 0)
                {
                    SpawnAlienShipAtRandom();

                    Timer = SetTimer;
                    AlienKeeper.GetComponent<ASK>().IsAlien = true;

                }
            }
        }

    }
    public void SpawnAlienShipAtRandom()
    {
        int WhereSpawn = Mathf.RoundToInt(Random.Range(0, Spawnpoints.Length));
        Instantiate(Alien, Spawnpoints[WhereSpawn].transform.position, Quaternion.identity);

    }

}
