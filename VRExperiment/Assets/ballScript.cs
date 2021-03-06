using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballScript : MonoBehaviour {

	public GameObject ball;
	public GameObject oRacket;
	public GameObject pRacket;
	public GameObject rHand;

	public Collider pArea;
	public Collider oArea;
	public Collider pSide;
	public Collider oSide;
	public Collider floor;
	public Collider table;

	public Text pText;
	public Text oText;

	Vector3 startingPoint = new Vector3 (-35.25f, 1.356f, 1.249f);
	Rigidbody rb;

	Collider prc;
	Collider orc;

	bool pTurn = true;
	bool pHit = false;
	bool oHit = false;
	bool oS = false;
	bool pS = true;

	int pScore = 0;
	int oScore = 0;
	int count = 0;

	void Start () {
		rb = ball.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		pText.text = ""+pScore;
		oText.text = ""+oScore;
		if (count > 1) {
			if (pTurn == true) {
				if (oS == true)
					pScore++;
				else
					oScore++;
			} else {
				if (pS == true)
					oScore++;
				else
					pScore++;
			}
			StartCoroutine(resetBall());
		}
	}

	IEnumerator resetBall()
	{
		count = 0;
		pHit = false;
		oHit = false;
		pTurn = true;
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

		if (other == table) {
			count++;
			if (pTurn) {
				pHit = true;
				oHit = false;
			} else {
				pHit = false;
				oHit = true;
			}
		}

		else if (other == oSide) {

			oS= true;
			pS = false;
		}
		else if (other == pSide) {
			oS= false;
			pS = true;
		} 
		else if (other == floor) {
			if (pTurn == true && pHit == false)
				oScore++;
			else if (pTurn == true && pHit == true) {
				if (oS)
					pScore++;
				else
					oScore++;
			}

			else if (pTurn == false && oHit == true)
			{
				if (oS)
					pScore++;
				else
					oScore++;
			}
			else if (pTurn == false && oHit == false)
				pScore++;
				
			StartCoroutine (resetBall ());
		} 
			
	}
	void OnTriggerExit (Collider other)
	{
		if (other == pArea) {
			pTurn = true;
			pHit = false;
			oHit = false;
			count = 0;
		} else if (other == oArea) {
			pTurn = false;
			pHit = false;
			oHit = false;
			count = 0;
		}
	}

}
