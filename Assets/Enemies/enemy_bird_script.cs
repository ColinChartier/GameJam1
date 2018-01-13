using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bird_script : obstacle_script {
    static int next_dir = 1;
    int dir;

	// Use this for initialization
	void Start () {
		dir = next_dir;
        next_dir *= -1;
        pos = GetComponent<Transform>();
        pos.SetPositionAndRotation(new Vector3(-dir*cam.orthographicSize*1.1f*16f/10f, -(0.5f*Random.value+0.5f)*cam.orthographicSize), new Quaternion());
	}

	// Update is called once per frame
	void Update () {
        pos.Translate(new Vector3(0.25f*dir, 0.1f));
        if (pos.position.y >= 2*cam.orthographicSize) {
            Destroy(this.gameObject);
        }
	}
}
