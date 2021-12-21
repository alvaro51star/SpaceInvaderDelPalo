using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAsteroid : MonoBehaviour
{
    public GameObject asteroid;
    public Transform positionRespawn;
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
        if (timeTillNextAsteroid <= 0)
        {
            Instantiate(asteroid, new Vector3(Random.Range(8f, -8f), positionRespawn.position.y, 0), Quaternion.identity);
            timeTillNextAsteroid = timeAsteroid;
        }
    }
}
