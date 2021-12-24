using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "asteroide" || collision.gameObject.tag == "enemigoNormal" || collision.gameObject.tag == "kamikaze" || collision.gameObject.tag == "balaEnemigo")
        {
            Destroy(collision.gameObject);
            TakeDamage(1);

            //Muerte
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
                gameOver.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else if (collision.gameObject.tag == "botiquin")
        {
            Curar(1);
            Destroy(collision.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Curar(int cura)
    {
        //Solo se cura si esta herida la nave
        if(currentHealth < maxHealth)
        {
            currentHealth += cura;
            healthBar.SetHealth(currentHealth);
        }
    }
}
