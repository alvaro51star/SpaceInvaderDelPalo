using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    Text score;
    public static int puntuacion = 0;
    // Start is called before the first frame update
    
    private void Start()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = puntuacion.ToString();
    }
}
