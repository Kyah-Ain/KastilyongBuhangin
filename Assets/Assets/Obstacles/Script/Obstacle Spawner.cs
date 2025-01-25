using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject land;
    public float spawnRate = 2;
    private float timer = 0;
    //public float heightOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        } 
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        Instantiate(land, new Vector3(Random.Range(-12, 11), transform.position.y, 1), transform.rotation);
    }
}
