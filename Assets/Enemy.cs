using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 3;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage){
        currentHealth-=damage;
        animator.SetTrigger("Hit");
        if (currentHealth<=0){
            Die();
        }
    }

    void Die(){
        animator.SetBool("IsDead", true);
        Destroy(gameObject);
    }

}
