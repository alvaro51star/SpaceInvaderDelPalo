using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private float movement = 0;
    public float velocidad = 1f;
    public float tiempoDeRecarga = 0.5f;
    public Transform balaLoc;
    public float bulletSpeed;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDeRecarga -= Time.deltaTime;
        //Transforma el movimiento de las flechas en lo que hay que mover el vector
        movement = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        //Se mueve
        

        if(gameObject.transform.position.y < -4)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -4, gameObject.transform.position.z);
        }
        else if(gameObject.transform.position.y > 4)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4, gameObject.transform.position.z);
        }
        else
        {
            gameObject.transform.Translate(0, movement, 0);
        }

        //Que no pueda disparar todo el tiempo
        if (Input.GetKeyDown("space") && tiempoDeRecarga <=0)
        {
            Shot();
            tiempoDeRecarga = 0.5f;
        }
        
    }

    

    void Shot()
    {
        GameObject bulletSpawn = Instantiate(bullet, balaLoc.position, bullet.transform.rotation);
        bulletSpawn.GetComponent<Rigidbody2D>().velocity = new Vector3(bulletSpeed, 0, 0);
        Destroy(bulletSpawn, 2);
    }



}
