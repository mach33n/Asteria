using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class RotateUranus : MonoBehaviour {
	Hand hand;
	Controller controller;
	// Use this for initialization
	void Start () {
		hand = new Hand ();
		controller = new Controller ();
	}

	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.up * Time.deltaTime * 75);

		Frame frame = controller.Frame ();
		if (frame.Hands.Count > 0) {
			List<Hand> hands = frame.Hands;
			hand = hands [0];


			if (hand.PalmVelocity.x > 500f) {
				if (hand.IsLeft) {
					transform.Rotate (Vector3.left * Time.deltaTime * 200, Space.World);
				}
			}
		}
	}
}
