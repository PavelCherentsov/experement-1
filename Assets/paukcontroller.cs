using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class paukcontroller : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;
    private Animator animator;
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        health = 10;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
        
    }
    private Transform target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.transform;
            animator.SetBool("visible player", true);
        }
    }

    public void RecieveDamage()
    {
        health -= 1;
        if (health <= 0)
            Destroy(gameObject);
    }
}
