using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;
    
    public int maxHealth = 100;
    int currentHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        if(currentHealth <= 0)
        {
            Die();
        }
        currentHealth -= damage;

        //Play Hurt Animation
        animator.SetTrigger("Hurt");

        if(currentHealth < 200)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
        }

       
    }

    void Die()
    {
        Debug.Log("Enemy Died");
        animator.SetBool("IsDead", true);

        //GetComponent<Collider2D>().enabled = false;
        /*if(GetComponent<Move>().enabled == false)
        {
             GetComponent<BossRun>().speed = 0f;
            GetComponent<BossRun>().attackRange = 0f;
        }*/
        GetComponent<Move>().enabled = false;
        this.enabled = false;
    }
    // Update is called once per frame
   
}
