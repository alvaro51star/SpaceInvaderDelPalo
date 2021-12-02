using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destruirBala : MonoBehaviour
{
    public Text text;
    private string scoreText;
    public static int puntos = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
            puntos = SumarPuntos();
            Puntuacion.puntuacion++;          
        }
    }

    private int SumarPuntos()
    {
        puntos++;
        return puntos;
    }

    
}
