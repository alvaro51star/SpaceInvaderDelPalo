using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirImpactoOtraBala : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            Destroy(gameObject);
        }
    }
}
