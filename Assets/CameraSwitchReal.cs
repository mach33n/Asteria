using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class CameraSwitchReal : MonoBehaviour {
	public Camera[] cams;
	int camCount = 0;
	Controller controller;
	Hand hand;
	int count;
	bool didAlready;
	// Use this for initialization
	void Start () {
		hand = new Hand ();
		controller = new Controller ();
		didAlready = false;
	}

	// Update is called once per frame
	void Update () {
		
		Frame frame = controller.Frame ();

		if (frame.Hands.Count > 0) {
			List<Hand> hands = frame.Hands;
			hand = hands [0];
		}

		float grabAngle = hand.GrabAngle;

		if (count == 100){
			didAlready = false;
			count = 0;
				if (grabAngle >= 1.5f) {
					if (hand.IsRight) {
						if (camCount >= 8) {
							camCount = 0;
							switch (camCount) {
							case 0:
								cams [0].enabled = true;
								cams [9].enabled = false;
								didAlready = true;
								break;
							}
						} 
						else {
							camCount = camCount + 1;
							switch (camCount) {
							case 0:
								cams [0].enabled = true;
								cams [9].enabled = false;
								didAlready = true;
								break;
							case 1:
								cams [1].enabled = true;
								cams [0].enabled = false;
								didAlready = true;
								break;
							case 2:
								cams [2].enabled = true;
								cams [1].enabled = false;
								didAlready = true;
								break;
							case 3:
								cams [3].enabled = true;
								cams [2].enabled = false;
								didAlready = true;
								break;
							case 4:
								cams [4].enabled = true;
								cams [3].enabled = false;
								didAlready = true;
								break;
							case 5:
								cams [5].enabled = true;
								cams [4].enabled = false;
								didAlready = true;
								break;
							case 6:
								cams [6].enabled = true;
								cams [5].enabled = false;
								didAlready = true;
								break;
							case 7:
								cams [7].enabled = true;
								cams [6].enabled = false;
								didAlready = true;
								break;
							default:
								cams [0].enabled = true;
								didAlready = true;
								break;
							}
						}
							}
				}else{
				}
		}else{
			count = count + 1;
		}
	}
	}

