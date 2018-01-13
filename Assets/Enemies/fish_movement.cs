using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_movement : MonoBehaviour {

    public Camera cam;
    private float yspeed;
    private float xspeed;

	// Use this for initialization
	void Start () {
        yspeed = Random.value * (cam.orthographicSize / 2) + (cam.orthographicSize / 10);
    }
	
	// Update is called once per frame
	void Update () {
        yspeed -= 2.0f;
	}
}
