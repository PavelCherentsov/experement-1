using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATTACKA : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Health>().Damege();
        }
    }
}
