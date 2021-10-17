using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
//    public GameObject deathanimation;
//    public Animator animator;
    public boss_health_bar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            die();
        }
        healthBar.SetHealth(currentHealth);

    }

    void die()
    {
//        Instantiate(deathanimation, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }

}