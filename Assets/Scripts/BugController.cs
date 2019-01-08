using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugController : ActorController {

    public float angle;
    public Quaternion _targetRotation;

	// Use this for initialization
	void Start () {
        persist = true;
    }
	
	// Update is called once per frame
	void Update () {
        persistence();


        if (Input.GetKey(KeyCode.A))
        {
            angle  += 100 * Time.deltaTime;//= Mathf.Min(175f, angle + 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            angle -= 100 * Time.deltaTime;// = Mathf.Max(-175f, angle - 1);
        }


        // Lerp to target rotation
        _targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, _targetRotation, 10f);
        
    GetComponent<Rigidbody2D>().velocity = transform.up * 5f;
	}


}
