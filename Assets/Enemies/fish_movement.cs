using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_movement : MonoBehaviour {

    public Camera cam;
    private float yspeed;
    private float xspeed;
    private float start_x;
    public Transform pos;
    private Renderer render;

    // Use this for initialization
    void Start() {
        pos = GetComponent<Transform>();
        render = GetComponent<Renderer>();
        yspeed = Random.value * (cam.orthographicSize / 2) + (cam.orthographicSize / 10);
        start_x = Random.value * (cam.orthographicSize * 16f / 10f);
        float dircheck = Random.value;
        if (dircheck <= 0.5) {
            xspeed = 1.5f * cam.orthographicSize / 30f;
            start_x *= -1;
        } else {
            xspeed = -1.5f * cam.orthographicSize / 30f;
        }
        pos.SetPositionAndRotation(new Vector3(start_x, cam.orthographicSize * -1, 0), new Quaternion());
    }
	
	// Update is called once per frame
	void Update () {
        if (!render.isVisible) {
            Destroy(this.gameObject);
        }

        pos.SetPositionAndRotation(new Vector3(pos.position.x + xspeed, pos.position.y + yspeed), new Quaternion());
        yspeed -= 0.1f * cam.orthographicSize / 3f;
	}
}
