using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigo : MonoBehaviour
{
    Transform posicion;
    public float velocidad;
    public float limiteMovimientoLateral; //Si el signo es menos, es el limite por la izquierda y si es positivo por la derecha
    private int direccionMovimiento = 1;
    Rigidbody2D rb;
    public float limiteVertical;
    public float tiempoBajada;
    private bool rightMovement = true;
    private bool bajadaHecha = false;


    public GameObject balas;
    public Transform balaLoc;
    public float velocidadBala;
    public float tiempoEntreDisparo;
    private float tiempoActual = 0;



    // Start is called before the first frame update
    void Start()
    {
        posicion = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Primera Fase movimiento, bajada hasta 3 (DONE)
        if (posicion.transform.position.y > limiteVertical)
        {
            MovimientoVertical();
        }
        else
        {
            Stop();
            bajadaHecha = true;
        }

        //Segunda fase
        if (posicion.transform.position.y >= 0 && bajadaHecha == true)
        {
            MovimientoLateral(direccionMovimiento);
            tiempoActual -= Time.deltaTime;
            if (posicion.transform.position.x >= limiteMovimientoLateral)
            {
                direccionMovimiento = -1;
            }else if(posicion.transform.position.x <= -limiteMovimientoLateral)
            {
                direccionMovimiento = 1;
            }

            //Disparo una vez llega a la segunda fase
            if(tiempoActual <= 0)
            {
                Shot();
                tiempoActual = tiempoEntreDisparo;
            }
        }


    }


    void Stop()
    {
        rb.velocity = new Vector2(0, 0);
    }

    void MovimientoLateral(int desplazamiento)
    {
        rb.velocity = new Vector2(desplazamiento * velocidad, rb.velocity.y);
    }

    void MovimientoVertical()
    {
        rb.velocity = new Vector2(0, -velocidad);
    }

    void Shot()
    {
        GameObject bulletSpawn= Instantiate(balas, balaLoc.position, balas.transform.rotation);
        
        bulletSpawn.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -velocidadBala, 0);

        Destroy(bulletSpawn, 2);
    }
}
