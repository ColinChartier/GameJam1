using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    int totalCounter = 0;
    public GameObject cityscape;
    public int x = 0;
    float nextSpawn = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalCounter++;
        if (totalCounter == 1)
        {
            nextSpawn = Random.Range(70, 400);
            Instantiate(cityscape, new Vector3(-5, 0), new Quaternion(0, 0, 0, 0));
            x++;
        }
    }
}
