using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalWindow : MonoBehaviour
{
    [SerializeField] private GameObject modal;
    private void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            modal.SetActive(!modal.activeSelf);
            Cursor.visible = !modal.activeSelf;
            Time.timeScale = !modal.activeSelf ? 1 :0;
        }
    }
}
