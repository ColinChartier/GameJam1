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

    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.name != "Raindrop") {
            return;
        }
        Debug.Log("Player has hit obstacle");
        //if (collision.gameObject.score > size) {
            Debug.Log("Player should absorb obstacle.");
        //} else {
            Debug.Log("Player should be damaged by obstacle.");
        //}
    }
}
