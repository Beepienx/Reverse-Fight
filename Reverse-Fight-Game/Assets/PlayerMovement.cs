using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	public CharacterController2D controller;
	
	public float RunSpeed = 10f;
	
	float HorizontalMove = 0f;
	
    void Update()
    {
        
		
		
    }
	
	void FixedUpdate () 
	{	
		HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
		controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
		
		
	}
	
}
