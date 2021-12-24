using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadorTiempo : MonoBehaviour
{
    public float tiempo;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        text.text = tiempo.ToString("0.00");
    }
}
