using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Kino;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private AnalogGlitch analogGlitch;
    [SerializeField] private DigitalGlitch digitalGlitch;
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
        digitalGlitch.intensity = (1-health)/2.5f;
        analogGlitch.scanLineJitter = (1-health)/2.5f;

        slider.value = health;
    }

    public void Damege()
    {
        health -= 0.2f;
    }
}