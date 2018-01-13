using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_movement : MonoBehaviour {

    public Camera cam;
    private float yspeed;
    private float xspeed;
    private float start_x;
    private int dir;
    public Transform pos;

	// Use this for initialization
	void Start () {
        pos = GetComponent<Transform>();
        yspeed = Random.value * (cam.orthographicSize / 2) + (cam.orthographicSize / 10);
        start_x = Random.value * (cam.orthographicSize * 16f / 10f);
        float dircheck = Random.value;
        if (dircheck <= 0.5) {
            dir = 1;
            start_x *= -1;
        } else {
            dir = -1;
        }
    }
	
	// Update is called once per frame
	void Update () {
        // if ()
        yspeed -= 2.0f;
	}
}
