﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice2Script : MonoBehaviour
{
	static Rigidbody rb;
	public static Vector3 dice2Velocity;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		dice2Velocity = rb.velocity;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			DiceNumberTextScript.dice2Number = 0;
			float dirX = Random.Range(0, 500);
			float dirY = Random.Range(0, 500);
			float dirZ = Random.Range(0, 500);
			transform.position = new Vector3(4, 2, 0);
			transform.rotation = Quaternion.identity;
			rb.AddForce(transform.up * 500);
			rb.AddTorque(dirX, dirY, dirZ);
		}
	}
}
