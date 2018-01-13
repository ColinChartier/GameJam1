using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bug_script : obstacle_script {
	// Use this for initialization
	void Start () {
        pos = GetComponent<Transform>();
        pos.SetPositionAndRotation(new Vector3(-(2*Random.value-1)*cam.orthographicSize*1.1f*16f/10f, -1*cam.orthographicSize), new Quaternion());
	}

	// Update is called once per frame
	void Update () {
        pos.Translate(new Vector3(0.25f*(2*Random.value-1), 0.1f));
        if (pos.position.y >= 2*cam.orthographicSize) {
            Destroy(this.gameObject);
        }
	}
}
