using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    static Text score;
    public static float puntuacion = 0;
    private static int multiplicador = 1;
    private float tiempo;
    private float tiempoMultiplicador=60; //En segundos
    private float puntuacionASumar;
    
    private void Start()
    {
        puntuacionASumar = 0;
        tiempo = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= tiempoMultiplicador)
        {
            multiplicador++;
            tiempo = 0;
        }
    }


    public static void SumarPuntos(int puntosRecibidos)
    {
        puntosRecibidos *= multiplicador;
        puntuacion += puntosRecibidos;

        score.text = (puntuacion).ToString() + "x" + multiplicador;
    }
}
