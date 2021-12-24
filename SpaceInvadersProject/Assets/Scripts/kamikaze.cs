using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamikaze : MonoBehaviour
{
    public int maxHealth = 1;
    public int currentHealth;
    public HealthBar healthBar;

    public int probabilidadBotiquin = 1;
    public GameObject botiquin;



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
        if (collision.gameObject.tag == "bala" || collision.gameObject.tag == "asteroide")
        {
            Destroy(collision.gameObject);
            TakeDamage(1);

            //Condicion de muerte
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
                Puntuacion.SumarPuntos(3);
                //Probabilidad de que de botiquin
                if(Random.Range(1, 4) == probabilidadBotiquin)
                {
                    GameObject botiquinSpawn = Instantiate(botiquin, gameObject.transform.position, botiquin.transform.rotation);
                    Destroy(botiquinSpawn, 10);
                }
            }
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
