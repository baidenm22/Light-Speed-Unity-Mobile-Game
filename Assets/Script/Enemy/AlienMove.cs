using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMove : MonoBehaviour {

    public GameObject[] Points;
    public GameObject Alien;
    public int WhichOne;

    public int speed;

    private void Start()
    {

        


    }




    void Update()
    {
        Alien.transform.position = Vector2.MoveTowards(Alien.transform.position, Points[WhichOne].transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        if (collision.gameObject.tag == "Point1")
        {
            WhichOne = 1; 

        }
        if (collision.gameObject.tag == "Point2")
        {
            WhichOne = 0;
        }
    }


}
