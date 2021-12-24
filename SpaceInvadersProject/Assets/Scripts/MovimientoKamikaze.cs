using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoKamikaze : MonoBehaviour
{
    Transform posicion;
    public float velocidadLateral;
    public float velocidadVertical;
    public float limiteMovimientoLateral; //Si el signo es menos, es el limite por la izquierda y si es positivo por la derecha
    private int direccionMovimiento = 1;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        posicion = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoVertical();
        MovimientoLateral(direccionMovimiento);
        if (posicion.transform.position.x >= limiteMovimientoLateral)
        {
            direccionMovimiento = -1;
        }
        else if (posicion.transform.position.x <= -limiteMovimientoLateral)
        {
            direccionMovimiento = 1;
        }
    }

    void MovimientoLateral(int desplazamiento)
    {
        rb.velocity = new Vector2(desplazamiento * velocidadLateral, rb.velocity.y);
    }

    void MovimientoVertical()
    {
        rb.velocity = new Vector2(rb.velocity.x, -velocidadVertical);
    }
}
