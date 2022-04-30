using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovemetn : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horisontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horisontalMove));
        horisontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump")){
            jump = true;  
            animator.SetBool("IsJumping", jump);
        }
    }

    public void OnLanding(){
        animator.SetBool("IsJumping", false); 
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horisontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void OnCollisionEnter(Collision other){
        if (other.collider.name == "Door")
            SceneManager.LoadScene("Level02");
    }
}
