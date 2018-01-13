using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public int counter = 0;
    int totalCounter = 0;
    public GameObject cloud;
    public Sprite[] sprites;
    float nextSpawn = 0;

    // Use this for initialization
    void Start()
    {
        
    }

    Sprite getCloudSprite()
    {
        int rand = Random.Range(0, sprites.Length);
        return sprites[rand];
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        totalCounter++;
        if (counter >= nextSpawn)
        {
            counter = 0;
            nextSpawn = Random.Range(70, 400);
            GameObject cloudInstance = Instantiate(cloud, new Vector3(-5, Random.Range(-5, 5)), new Quaternion(0, 0, 0, 0));
            cloud.GetComponent<SpriteRenderer>().sprite = getCloudSprite();
        }
    }
}
