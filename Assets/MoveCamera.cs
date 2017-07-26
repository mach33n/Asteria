using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speedH;
	public float speedV;

	private float yaw;
	private float pitch;

	private float prevYaw;
	private float prevPitch;
	// Use this for initialization
	void Start () {
		speedH = 2f;
		speedV = 2f;

		prevYaw = 0.0f;
		prevPitch = 0.0f;

		yaw = 0.0f;
		pitch = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (-Input.GetAxis("Mouse Y") * speedV, Input.GetAxis("Mouse X") * speedH, 0.0f);
		/*
		if (x < 0) {
			transform.Rotate (0.0f, -1f, 0.0f);
		} else if (x > 0) {
			transform.Rotate (0.0f, 1f, 0.0f);
		}
		*/
		/*
		//print (Input.GetAxis("Mouse X"));
		float x = Input.GetAxis("Mouse X");
		yaw += speedH * x;
		pitch -= speedV * Input.GetAxis("Mouse Y");
		if (prevYaw != x) {
			if (prevYaw > x) {
				//print ("TESTING IF STATEMENT PKNFVPBNVKPOKEVBOEKBVOEBVOKBOEBEI");
				transform.Rotate (0.0f, -yaw, 0.0f);
			} 
			else {
				//print ("TESTING ELSE STATEMENT OBFOBOFVBEOFBOEFBOEFBOEIBFOEBO");
				transform.Rotate (0.0f, yaw, 0.0f);
			}
		}
		if (prevPitch != Input.GetAxis ("Mouse Y")) {
			transform.Rotate (pitch, 0.0f, 0.0f);
		}
		print (prevYaw + "---------------------------------------" + x);
		prevYaw = x;
		prevPitch = Input.GetAxis ("Mouse Y");
		*/
	}
}
