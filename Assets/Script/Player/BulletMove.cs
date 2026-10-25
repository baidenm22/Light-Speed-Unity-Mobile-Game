using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    public float DeathTimer;
    public GameObject Bullet;
    public int MovementSpeed;
    public GameObject Player;
    public int HasPericed;
    public float HitDelay;


    // Use this for initialization
    void Start () {

        Player = GameObject.FindGameObjectWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {

        HasPericed = Player.GetComponent<PowerUps>().Pericing;


        if (HitDelay > 0)
        {
            HitDelay -= Time.deltaTime;
        }


        DeathTimer -= Time.deltaTime;

        if (DeathTimer <= 0)
        {

            Destroy(Bullet);
            
        }



       Bullet.transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);


	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "ESHOT" && collision.gameObject.tag != "PBullet" && collision.gameObject.tag != "Player" && collision.gameObject.tag != "HU" && collision.gameObject.tag != "PU" && collision.gameObject.tag != "DSU" && collision.gameObject.tag != "Player2" && collision.gameObject.tag != "SEBUllet")
        {
            if (HasPericed < 1 && HitDelay <= 0)
            {
                Destroy(Bullet);

            } else
            {
                HasPericed -= 1;
                HitDelay = .5f; 
            }
        }
       

    }
}
