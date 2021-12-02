using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAsteroid : MonoBehaviour
{
    public GameObject asteroid;
    public float timeTillNextAsteroid = 2f;
    public float timeAsteroid = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTillNextAsteroid -= Time.deltaTime;
        if(timeTillNextAsteroid <= 0)
        {
            Instantiate(asteroid, new Vector3(12, Random.Range(3.85f, -3.85f), 0), Quaternion.identity);
            timeTillNextAsteroid = timeAsteroid;
        }
    }
}
