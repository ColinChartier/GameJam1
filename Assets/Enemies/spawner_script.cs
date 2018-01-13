using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_script : MonoBehaviour {
    public int counter = 0;
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
    GameObject prev2;
    GameObject prev1;
    GameObject cur;
    GameObject next1;
    GameObject next2;

    // Use this for initialization
    void Start () {
        prev2 = null;
        prev1 = null;
        cur = rain;
        next1 = bug;
        next2 = bird;
    }

    // Update is called once per frame
    void Update () {
        SetEnemyLevels();
        counter++;
        counter %= 480;
        if (counter == 0) {
            if (next2 != null) {
                Instantiate(next2).GetComponent<obstacle_script>().cam = cam;
            }
        } else if (counter == 240) {
            if (next1 != null) {
                Instantiate(next1).GetComponent<obstacle_script>().cam = cam;
            }
        } else if (counter % 120 == 0) {
            if (cur != null) {
                Instantiate(cur).GetComponent<obstacle_script>().cam = cam;
            }
        } else if (counter % 60 == 0) {
            if (prev1 != null) {
                Instantiate(prev1).GetComponent<obstacle_script>().cam = cam;
            }
        } else if (counter % 30 == 0) {
            if (prev2 != null) {
                Instantiate(prev2).GetComponent<obstacle_script>().cam = cam;
            }
        }
    }

    void SetEnemyLevels() {
        if (next1 == null) {
            return;
        }
        if (player.GetComponent<RainMovement>().score >= next1.GetComponent<obstacle_script>().size) {
            prev2 = prev1;
            prev1 = cur;
            cur = next1;
            next1 = next2;
            if (next1 == bird) {
                next2 = kite;
            } else if (next1 == kite) {
                next2 = human;
            } else if (next1 == human) {
                next2 = shark;
            } else if (next1 == shark) {
                next2 = plane;
            } else if (next1 == plane) {
                next2 = whale;
            } else if (next1 == whale) {
                next2 = null;
            }
        }
    }
}
