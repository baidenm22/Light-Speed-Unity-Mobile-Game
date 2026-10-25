using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShoot : MonoBehaviour {

    public float Timer;
    public GameObject Bullet;
    public GameObject Self;
    public float GoOnTimer;




    // Use this for initialization
    void Start () {
        Self.transform.position = new Vector2(6, Self.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {

        Self.transform.position = new Vector2(6, Self.transform.position.y);
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            Instantiate(Bullet, Self.transform.position, Quaternion.identity);
            Timer = GoOnTimer;
        }


	}
}
