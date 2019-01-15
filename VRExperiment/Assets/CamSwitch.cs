using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;


	void Start() {
		cam1.SetActive (true);
		cam2.SetActive (false);
		cam3.SetActive (false);
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.Keypad4)) {
			cam1.SetActive (true);
			cam2.SetActive (false);
			cam3.SetActive (false);
		}
		else if (Input.GetKeyDown (KeyCode.Keypad5)) {
			cam1.SetActive (false);
			cam2.SetActive (true);
			cam3.SetActive (false);
		}
		else if (Input.GetKeyDown (KeyCode.Keypad6)) {
			cam1.SetActive (false);
			cam2.SetActive (false);
			cam3.SetActive (true);
		}
	}

}