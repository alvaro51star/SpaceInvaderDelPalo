using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigoNormal : MonoBehaviour
{
    public GameObject enemigoNormal;
    public Transform positionRespawn;
    public float timeTillNextEnemy = 0f;
    public float timeNormalEnemy = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeTillNextEnemy -= Time.deltaTime;
        if (timeTillNextEnemy <= 0)
        {
            Instantiate(enemigoNormal, new Vector3(Random.Range(7f, -7f), positionRespawn.position.y, 0), Quaternion.identity);
            timeTillNextEnemy = timeNormalEnemy;
        }
    }
}
