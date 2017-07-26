using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class SwitchCamera : MonoBehaviour {
	Hand hand;
	Controller controller;
	Camera[] cameras;
	// Use this for initialization
	void Start () {
		cameras = new Camera[10];
		print(Camera.GetAllCameras (cameras));
		cameras [0].enabled = true;
		cameras [1].enabled = false;
		hand = new Hand ();
		controller = new Controller(); 
	}
	
	// Update is called once per frame
	void Update () {
		print (cameras.Length);
		Frame frame = controller.Frame ();
		//print ("ifvgeofhwoegfoewbfowevfowvfwvefiwvfihwvefhwvefhwvfhwvfihwvefihwvfihwvfihwvefihwvefihwvefihwvefihwvf");
		if (frame.Hands.Count > 0) {
			List<Hand> hands = frame.Hands;
			hand = hands [0];
		}
			
		float grabAngle = hand.GrabAngle;

		if (grabAngle >= 1.0f) {
			if (hand.IsRight) {
				print (cameras[0].enabled+ ","+ cameras[1].enabled);
				cameras [0].enabled = false;
				cameras [1].enabled = true;
			}
		}
		if (grabAngle < 2.0f) {
			if (hand.IsRight) {
				cameras [0].enabled = true;
				cameras [1].enabled = false;
			}
		}
}
}
