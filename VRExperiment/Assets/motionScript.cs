using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionScript : MonoBehaviour {

	float speed;
	private float time;
	public Transform rHand;
	Vector3 newPos;

	// Use this for initialization
	void Start () {
		speed = 1f;
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		newPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z); 

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			Debug.Log ("Mult: " + speed);
			time = 0;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			speed += 0.01f;
			transform.Translate (newPos * Time.deltaTime*speed);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.position = rHand.position;		
		}
	}
}
