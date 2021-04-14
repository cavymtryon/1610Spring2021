﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float rpm;
    [SerializeField] float speed;
    [SerializeField] float horsePower = 0;
    private const float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;

    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

     void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        if (IsOnGround())
        {

            // Move the vehicle forward based on vertical input
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);

            //Turning Vehicle
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

            //print speed
            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed:" + speed + "mph");

            //print RPM
            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM:" + rpm);
        }

        
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
