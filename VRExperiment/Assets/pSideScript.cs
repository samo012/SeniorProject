using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pSideScript : MonoBehaviour {

	public GameObject ball;
	public GameObject oRacket;
	public GameObject pRacket;

	public Collider pSide;
	public Collider oSide;
	public Collider floor;
	public Collider table;
	Vector3 startingPoint = new Vector3 (-35.46f, 2f, 1.762f);
	Rigidbody rb;
	Collider orc;
	Collider prc;


	int count = 0;
	// Use this for initialization
	void Start () {
		rb = ball.GetComponent<Rigidbody>();
		orc = oRacket.GetComponent<Collider> ();
		prc = oRacket.GetComponent<Collider> ();


		
	}
	
	// Update is called once per frame
	void Update () {
		
			
	}

	IEnumerator resetBall()
	{
		count = 0;
		rb.velocity = Vector3.zero;
		ball.transform.position = startingPoint;
		rb.isKinematic =true;
		//rb.useGravity =false;

		yield return new WaitForSeconds (2f);
		rb.isKinematic =false;
		//rb.useGravity =true;

	}
		
	void OnTriggerEnter (Collider other)
	{
		//if (other == pSide)
			//Debug.Log ("player side");
		if (other == table)
			count++;
		else if (other == oSide) {
			Debug.Log ("OSide");
			oRacket.transform.position = ball.transform.position;
		} else if (other == floor) {
			Debug.Log ("floor");
			StartCoroutine(resetBall());
		}

		else if (other == prc)
			count = 0;
		else if (other == orc)
			count = 0;
		
		if (count > 1) {
			Debug.Log ("point");
			StartCoroutine(resetBall());
		}

		
	}
	void OnTriggerStay (Collider other)
	{
		//if (other == table)
			//Debug.Log ("table");
	}

}
