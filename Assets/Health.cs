using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private float health;

    private void Start()
    {
        health = 0.25f;
    }

    public void AddHP()
    {
        health += 0.5f;
    }

    void Update()
    {
        if (health > 0)
            health -= 0.0001f;
        slider.value = health;
    }
}