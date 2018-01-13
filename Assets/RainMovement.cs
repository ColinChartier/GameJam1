using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainMovement : MonoBehaviour {

    public float speed = 3;
    public int score;
    public Transform pos;

	// Use this for initialization
	void Start () {
        //pos = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        // Get keys
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        pos.SetPositionAndRotation(new Vector3(pos.position.x + x * speed, pos.position.y + y * speed, pos.position.z), new Quaternion());
	}
}
