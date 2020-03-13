using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public CharacterController2D controller;
    public float movement = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       movement = Input.GetAxisRaw("Horizontal") * runSpeed;
       if(Input.GetButtonDown("Jump")){
           jump = true; 
       }
    }

    void FixedUpdate() {
        controller.Move(movement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
