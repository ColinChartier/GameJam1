using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_script : MonoBehaviour {
    public int counter = 0;
    public GameObject obstacle;
    public int x = 0;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        counter++;
        if (counter == 120) {
            counter = 0;
            Instantiate(obstacle, new Vector3(x, 0), new Quaternion());
            x++;
        }
    }
}
