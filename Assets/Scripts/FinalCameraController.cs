using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCameraController : MonoBehaviour {

    public Transform target;
    public float offset;

    // Use this for initialization
    void Start()
    {
        offset = GlobalUtils.FIELD_UNIT_HEIGHT * 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + offset, -10f);
    }
}