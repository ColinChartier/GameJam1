using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public int counter = 0;
    public GameObject cloud;
    public int x = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == 120)
        {
            counter = 0;
            Instantiate(cloud, new Vector3(-5, 0), new Quaternion(0, 0, 90, 0));
            x++;
        }
    }
}
