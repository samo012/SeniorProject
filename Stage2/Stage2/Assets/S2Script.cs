using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S2Script : MonoBehaviour {

	public GameObject gun;
	public GameObject hand;
	public Text mult;

	public static float dft = 1.0f;
	public static float multiplier = dft;
	public static float max = 4.0f;
	public static float min = 0.01f;



	// Use this for initialization
	void Start () {
		multiplier = dft;
	}

	// Update is called once per frame
	void Update () {
		checkMultiplier ();

		//= new Vector3 (gun.transform.position.x*xMult, gun.transform.position.y*yMult, -gun.transform.position.z*zMult);
		
	}
	/*
	public static Vector3 createTransform(Vector3 position){
		return position = new Vector3 (position.x*xMult, position.y*yMult, -position.z*zMult);
	}*/

	void checkMultiplier(){
		if (Input.GetKeyDown (KeyCode.Space)) {

			mult.text= "Multiplier: " + multiplier;

		}

		if (multiplier >= 0 && multiplier <= max) {

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				multiplier += 0.001f;
				gun.transform.position = gun.transform.position * multiplier;				

			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {

				gun.transform.position = gun.transform.position / multiplier;

			}



			if (Input.GetKeyDown (KeyCode.Keypad2)) {
				multiplier = dft;

			}


		} else
			multiplier = min;

	}
}
