using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitGame : MonoBehaviour
{
   
    public void OnTriggerEnter2D(){
        SceneManager.LoadScene("Level02");

    }
}
