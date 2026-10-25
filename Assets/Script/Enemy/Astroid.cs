using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour {


    public float MovementSpeed;
    public GameObject Self;
    public float lifespan;
    public float Diff;
  
    

	// Use this for initialization
	void Start () {

         
	}
	
	// Update is called once per frame
	void Update () {

        

        lifespan -= Time.deltaTime;


        if (lifespan <= 0)
        {
            Destroy(Self);
        }
        Self.transform.position = new Vector2(Self.transform.position.x + (-1 * Time.deltaTime * MovementSpeed),Self.transform.position.y);


	}

}
