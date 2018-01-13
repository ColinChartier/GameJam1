using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_script : MonoBehaviour {
    public int counter = 0;
    public int x = 0;
    public Camera cam;
    public GameObject player;
    [Header("Enemy Types")]
    public GameObject rain;
    public GameObject bug;
    public GameObject bird;
    public GameObject kite;
    public GameObject human;
    public GameObject shark;
    public GameObject plane;
    public GameObject whale;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        counter++;
        if (counter == 120) {
            counter = 0;
            Instantiate(bird).GetComponent<obstacle_script>().cam = cam;
            x++;
        }
    }
}
