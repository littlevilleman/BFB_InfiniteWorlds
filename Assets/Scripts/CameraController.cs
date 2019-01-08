using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : ActorController {

    public Transform target;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		transform.position = new Vector3(target.position.x, target.position.y/* + GlobalUtils.REAL_FIELD_HEIGHT * 2 - 24f*/, -10f);
	}
}
