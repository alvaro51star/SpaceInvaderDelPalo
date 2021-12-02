using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoAsteroide : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject bala;
    public float velocidadAsteroide = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(-velocidadAsteroide, 0, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            Destroy(gameObject);
        }
    }
}
