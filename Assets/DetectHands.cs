using System.Collections;
using UnityEngine;
using Leap;
using System.Collections.Generic;


public class DetectHands : MonoBehaviour {
	Controller controller;
	Hand one;
	Hand two; 
	private GameObject s;
	// Use this for initialization
	void Start () {
		controller = new Controller ();
		one = new Hand ();
		two = new Hand ();
		//print ("Testing");
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame ();
		if (frame.Hands.Count > 0) {
			List<Hand> hands = frame.Hands;
			one = hands [0];
			two = hands [1];
		}

		float grabAngle = one.GrabAngle;

		//print (one.PalmPosition.x);

		if (grabAngle >= 1.0) {
			GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			Rigidbody gOR = sphere.AddComponent<Rigidbody> ();
			gOR.useGravity = true;
			sphere.transform.position = new Vector3(one.PalmPosition.x / 1000f, (one.PalmPosition.y) / 1000f, 
				((one.PalmPosition.z) / 1000f));
		    sphere.transform.localScale -= new Vector3 (0.95f, 0.95f, 0.95f);
		}
			
	}
}
