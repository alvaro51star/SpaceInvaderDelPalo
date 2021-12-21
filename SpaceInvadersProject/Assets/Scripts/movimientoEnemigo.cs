using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigo : MonoBehaviour
{
    Transform posicion;
    public float velocidad;
    public GameObject balas;
    public float limiteMovimientoLateral; //Si el signo es menos, es el limite por la izquierda y si es positivo por la derecha
    private int direccionMovimiento = 1;
    Rigidbody2D rb;
    public float tiempoBajada;
    private bool rightMovement = true;
    private bool bajadaHecha = false;

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
        if (posicion.transform.position.y > 3)
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

        }


    }

    void Movimiento()
    {
        if (posicion.transform.position.x < 3)
        {

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
}
