using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAstroid : MonoBehaviour {

    public float MovementSpeed;
    public GameObject Self;

    public float lifespan;


    // Use this for initialization
    void Start()
    {
        Self.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
        lifespan -= Time.deltaTime;

        Self.transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);

        if (lifespan <= 0)
        {
            Destroy(Self);
        }

    }
   
}
