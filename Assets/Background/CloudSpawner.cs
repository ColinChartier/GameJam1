using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public int counter = 0;
    public GameObject cloud;
    public int x = 0;
    float nextSpawn = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter >= nextSpawn)
        {
            counter = 0;
            nextSpawn = Random.Range(70, 400);
            Instantiate(cloud, new Vector3(-5, Random.Range(-5, 5)), new Quaternion(0, 0, 90, 0));
            x++;
        }
    }
}
