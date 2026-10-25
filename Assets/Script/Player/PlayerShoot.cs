using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {


    public GameObject Bullet;
    public GameObject Player;
    public float ShotCooldown;
    public GameObject ShotSpawn2;
    public GameObject ShotSpawn1;
    public GameObject ShotSpawn3;
    public GameObject ShotSpawn4;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ShotCooldown -= Time.deltaTime;

#if UNITY_STANDALONE || UNITY_WEBGL

        if (Input.GetButtonDown("Fire1") &&  ShotCooldown <= 0)
        {
            if (Player.GetComponent<PowerUps>().DoubleShoot == true)
            {
                Instantiate(Bullet, ShotSpawn2.transform.position, Quaternion.identity);
                if (PlayerPrefs.GetInt("RU3") == 1)
                {
                    GameObject W1 = Instantiate(Bullet, ShotSpawn3.transform.position, Quaternion.identity);
                    GameObject W2 = Instantiate(Bullet, ShotSpawn4.transform.position, Quaternion.identity);
                    W1.gameObject.transform.rotation = ShotSpawn3.transform.rotation;
                    W2.gameObject.transform.rotation = ShotSpawn4.transform.rotation;
                }
            }
            Instantiate(Bullet, ShotSpawn1.transform.position, Quaternion.identity);
            ShotCooldown = 0.5f;
        }
    }
#endif



}
#if UNITY_ANDROID
public void ShootShot()
    {
        if (ShotCooldown <= 0)
        {
            if (Player.GetComponent<PowerUps>().DoubleShoot == true)
            {
                Instantiate(Bullet, ShotSpawn2.transform.position, Quaternion.identity);
                if (PlayerPrefs.GetInt("RU3") == 1)
                {
                   GameObject W1 = Instantiate(Bullet, ShotSpawn3.transform.position, Quaternion.identity);
                   GameObject W2 = Instantiate(Bullet, ShotSpawn4.transform.position, Quaternion.identity);
                    W1.gameObject.transform.rotation = ShotSpawn3.transform.rotation;
                    W2.gameObject.transform.rotation = ShotSpawn4.transform.rotation;
                }
            }
            Instantiate(Bullet, ShotSpawn1.transform.position, Quaternion.identity);
            ShotCooldown = 0.5f;
        }
    }


}

#endif