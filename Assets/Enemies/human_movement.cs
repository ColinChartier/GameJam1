using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human_movement : obstacle_script {

    private float yspeed;
    private float start_x;
    private Renderer render;

    // Use this for initialization
    void Start () {
        pos = GetComponent<Transform>();
        render = GetComponent<Renderer>();
        yspeed = -Random.value * (cam.orthographicSize / 60f);
        start_x = Random.value * (cam.orthographicSize * 16f / 10f);
        pos.SetPositionAndRotation(new Vector3(start_x, cam.orthographicSize, 0), new Quaternion());
    }
	
	// Update is called once per frame
	void Update () {
        if (!render.isVisible)
        {
            Destroy(this.gameObject);
        }

        pos.SetPositionAndRotation(new Vector3(pos.position.x, pos.position.y + yspeed), new Quaternion());
    }
}
