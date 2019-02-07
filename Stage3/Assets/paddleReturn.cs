using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleReturn : MonoBehaviour {
	public GameObject character;
	public GameObject pRacket;
	public Collider floor;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			character.transform.position = new Vector3 (-35.08f, 1.93f, 1.0f);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other == floor) {
			pRacket.transform.position = new Vector3 (-35.08f, 1.93f, 1.677f);
		}
	}
}
