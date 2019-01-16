using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S2Script : MonoBehaviour {


	public Text mult;
	public static float dft = 1.0f;
	public static float multiplier = dft;
	public static float max = 4.0f;
	public static float min = 0.01f;
	public static float xMult = dft;
	public static float yMult = dft;
	public static float zMult = dft;
	public static bool xPressed = true;
	public static bool yPressed = false;
	public static bool zPressed = false;

	// Use this for initialization
	void Start () {
		multiplier = dft;
		xMult = dft;
		yMult = dft;
		zMult = dft;

	}

	// Update is called once per frame
	void Update () {
		checkMultiplier ();
	}


	void checkMultiplier(){
		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			if (xPressed)
				mult.text = "X: " + xMult;
			else if (yPressed)
				mult.text = "Y: " + yMult;
			else if (zPressed)
				mult.text = "Z: " + zMult;
		}

		if (multiplier >= 0 && multiplier <= max) {

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				multiplier += 0.001f;
				if (xPressed)
					xMult = multiplier;
				else if (yPressed)
					yMult = multiplier;
				else if (zPressed)
					zMult = multiplier;
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				multiplier -= 0.001f;

				if (xPressed)
					xMult = multiplier;
				else if (yPressed)
					yMult = multiplier;
				else if (zPressed)
					zMult = multiplier;
			}

			if (Input.GetKeyDown (KeyCode.X)) {
				xPressed = true;
				yPressed = false;
				zPressed = false;
				yMult = dft;
				zMult = dft;
			}
			if (Input.GetKeyDown (KeyCode.Y)) {
				xPressed = false;
				yPressed = true;
				zPressed = false;
				xMult = dft;
				yMult = min;
				zMult = dft;
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				xPressed = false;
				yPressed = false;
				zPressed = true;
				yMult = dft;
				xMult = dft;
			}
			if (Input.GetKeyDown (KeyCode.Keypad1)) {
				multiplier = min;
				xMult = min;
				yMult = min;
				zMult = min;
			}
			if (Input.GetKeyDown (KeyCode.Keypad2)) {
				multiplier = max;
				xMult = max;
				yMult = max;
				zMult = max;
			}
			if (Input.GetKeyDown (KeyCode.Keypad3)) {
				multiplier = dft;
				xMult = dft;
				yMult = dft;
				zMult = dft;
			}

		} else
			multiplier = min;

	}
}
