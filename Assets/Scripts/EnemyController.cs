using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : ActorController {

	// Use this for initialization
	void Start ()
    {
        transform.Rotate(0.0f, 0.0f, Random.Range(90f, 270f));
    }
	
	// Update is called once per frame
	void Update () {
        persistence();
        GetComponent<Rigidbody2D>().velocity = transform.up * 5f;


    }
}
