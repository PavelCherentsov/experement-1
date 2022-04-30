using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatScript : MonoBehaviour
{
    
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 1;
    public LayerMask enemyLayers;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    public int maxHealth = 5;
    int currentHealth;

    void Start(){
        currentHealth = maxHealth;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime){
            if (Input.GetButtonDown("Fire1")){
              Attack();
              nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack(){
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies){
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    
}
