using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

	public GameObject cam1;
	public GameObject cam2;
	public bool camSwitch = false;



	void Start() {

	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.Space)) {
			camSwitch = !camSwitch;
			cam1.SetActive(camSwitch);
			cam2.SetActive(!camSwitch);

		}
	}
}