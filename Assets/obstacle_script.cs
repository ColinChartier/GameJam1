using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_script : MonoBehaviour {
    bool attached = false;
    public int size = 10;
    public int value = 0;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
    }

    void OnTriggerEnter2D (Collider2D collision) {
        if (collision.gameObject.name != "Rain drop") {
            return;
        }
        // Debug.Log("Player has hit obstacle");
        RainMovement scr = collision.gameObject.GetComponent<RainMovement>();
        if (scr.score > size) {
            Debug.Log("Player should absorb obstacle.");
            scr.UpdateScore(value);
            Destroy(this.gameObject);
        } else {
            Debug.Log("Player should be damaged by obstacle.");
            scr.UpdateScore(-1);
        }
    }
}
