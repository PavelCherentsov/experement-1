using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisiblePressE : MonoBehaviour
{
    [SerializeField] private static GameObject text;
    private static VisiblePressE current;
    private static Health health;

    private void Awake()
    {
        if (text == null)
            text = GameObject.FindGameObjectWithTag("PressE");
        if (health == null)
            health = FindObjectOfType<Health>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            current = this;
            text.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            current = null;
            text.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        if (current != null && Input.GetKey(KeyCode.E))
        {
            if (current == this)
            {
                health.AddHP();
                text.SetActive(false);
                Destroy(gameObject);
            }
        }

    }
}
