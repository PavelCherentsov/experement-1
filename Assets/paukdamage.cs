using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paukdamage : MonoBehaviour
{
    [SerializeField] private paukcontroller paukcontroller;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire")
        {
            paukcontroller.RecieveDamage();
        }
    }
}
