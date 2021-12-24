using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public float tiempoSpawnEnemigoNormal = 60;
    public float tiempoSpawnKamikaze = 30;

    private float time;

    public GameObject spawnEnemigo;
    public GameObject spawnKamikaze;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        //hacemos que empiecen si o si desactivados
        spawnEnemigo.SetActive(false);
        spawnKamikaze.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 30)
        {
            spawnKamikaze.SetActive(true);
        }
        if(time >= 60)
        {
            spawnEnemigo.SetActive(true);
        }
    }
}
