using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	public CharacterController2D controller;
	
	public float RunSpeed = 10f;
	float HorizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	
    void Update()
    {
        
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
		
		if (Input.GetButtonDown("Crouch")) 
		{
		crouch = true;	
	} else if (Input.GetButtonUp("Crouch"))
		{
		crouch = false;
		}
		
		
    }
	
	void FixedUpdate () 
	{	
		HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
		controller.Move(HorizontalMove * Time.fixedDeltaTime, crouch, jump);
		
		jump = false;

		
	}
	
}
