using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private float movement = 0;
    public float velocidad = 1f;
    public float tiempoDeRecarga = 0.5f;
    public Transform balaLoc;
    public Transform balaLoc2;
    public float bulletSpeed;
    public GameObject bullet;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDeRecarga -= Time.deltaTime;
        //Transforma el movimiento de las flechas en lo que hay que mover el vector
        movement = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        //Se mueve
        

        if(gameObject.transform.position.x < -7)
        {
            gameObject.transform.position = new Vector3(-7, gameObject.transform.position.y, gameObject.transform.position.z);
            rb.velocity = new Vector2(0,0);
            
        }
        else if(gameObject.transform.position.x > 7)
        {
            gameObject.transform.position = new Vector3(7, gameObject.transform.position.y, gameObject.transform.position.z);
            rb.velocity = new Vector2(0, 0);
        }
        else
        {
            gameObject.transform.Translate(movement, 0, 0);
        }

        //Que no pueda disparar todo el tiempo
        if (Input.GetKeyDown("space") && tiempoDeRecarga <= 0)
        {
            NormalShot();
            tiempoDeRecarga = 0.5f;
        }
        
    }

    

    void NormalShot()
    {
        GameObject bulletSpawn1 = Instantiate(bullet, balaLoc.position, bullet.transform.rotation);
        GameObject bulletSpawn2 = Instantiate(bullet, balaLoc2.position, bullet.transform.rotation);

        bulletSpawn1.GetComponent<Rigidbody2D>().velocity = new Vector3(0, bulletSpeed, 0);
        bulletSpawn2.GetComponent<Rigidbody2D>().velocity = new Vector3(0, bulletSpeed, 0);

        Destroy(bulletSpawn2, 2);
        Destroy(bulletSpawn1, 2);
    }



}
