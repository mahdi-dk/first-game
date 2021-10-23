using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject deathanimation;
    public Animator animator;
    public health__bar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    IEnumerator hurt()
    {
        animator.SetBool("IsHurting", true);


        yield return new WaitForSeconds(1f);


        animator.SetBool("IsHurting", false);
    }


    public void TakeDamage(int damage)
    {
        StartCoroutine(hurt());
        currentHealth -= damage;

        if (currentHealth <= 0) {
            die();
        }
        healthBar.SetHealth(currentHealth);

    }
    /*
    void Update() {
        
        if (animator.GetBool("IsHurting") == true) {
            animator.SetBool("IsHurting", false);
        }
        
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("hurt"))
        {
            animator.SetBool("IsHurting", false);
            // Avoid any reload.
        }
    
    }
    */
void die() 
    {
        Instantiate(deathanimation, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
