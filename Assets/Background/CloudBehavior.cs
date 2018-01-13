using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehavior : MonoBehaviour {
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(Random.Range(0.1f, 1f), 0);
        float scale = Random.Range(0.5f, 1.5f);
        transform.localScale *= Random.Range(0.1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
