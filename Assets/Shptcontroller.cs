using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shptcontroller : MonoBehaviour
{
    [SerializeField] private GameObject shot;
    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(shot, transform.position, transform.rotation);
        }
    }
}
