using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    private float maxHitpoints = 100;
    private float currentHitpoints;
    
    private Rigidbody2D rigidbody;
    private float horizontalInput;
    private float verticalInput;

    public float CurrentHitPoints // this is a property, it is made up of a "get"er and a "set"er
    {
        get
        {
            return currentHitpoints;
        }
        set // if you don't want other things to change the value of this, then don't define what the "set" is
            //Basically makes it a read only
        {

        }
    }

    public float CurrentHitpointsAsPercentage
    {
        get
        {
            return currentHitpoints / maxHitpoints;
        
        }
    }
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        CurrentHitPoints = maxHitpoints;
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetInput();
        HandleMovement();
	}

    private void HandleMovement()
    {
        rigidbody.velocity = new Vector2(horizontalInput, verticalInput) * speed*Time.deltaTime; 
    }

    private void GetInput()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

    }
    public void TakeDamage(float amount)
    {
        currentHitpoints -= amount;
    }
}
