
using UnityEngine;
using System.Collections;

public class lerp : MonoBehaviour
{
	/// <summary>
	/// The time taken to move from the start to finish positions
	/// </summary>
	public float timeTakenDuringLerp = 1f;
	public GameObject ball;
	public GameObject oRacket;

	public Collider oSide;


	/// <summary>
	/// How far the object should move when 'space' is pressed
	/// </summary>


	//Whether we are currently interpolating or not
	private bool _isLerping;

	//The start and finish positions for the interpolation
	private Vector3 _startPosition;
	private Vector3 _endPosition;
	public float speed = 50f;
	private Vector3 Ostart = new Vector3(-36.183f,1.92f,6.238f);
	bool oTurn = false;

	//The Time.time value when we started the interpolation
	private float _timeStartedLerping;

	/// <summary>
	/// Called to begin the linear interpolation
	/// </summary>
	void StartLerping()
	{
		_isLerping = true;
		_timeStartedLerping = Time.time;

		//We set the start position to the current position, and the finish to 10 spaces in the 'forward' direction
		_startPosition = oRacket.transform.position;
		if (oTurn) {
			speed = 5f;
			_endPosition = Ostart;

		} else {
			speed = 50f;
			_endPosition = ball.transform.position;
		}
		
	}


	//We do the actual interpolation in FixedUpdate(), since we're dealing with a rigidbody
	void FixedUpdate()
	{
		if(_isLerping)
		{
			//We want percentage = 0.0 when Time.time = _timeStartedLerping
			//and percentage = 1.0 when Time.time = _timeStartedLerping + timeTakenDuringLerp
			//In other words, we want to know what percentage of "timeTakenDuringLerp" the value
			//"Time.time - _timeStartedLerping" is.
			float timeSinceStarted = (Time.time - _timeStartedLerping)*speed;
			float percentageComplete = timeSinceStarted / timeTakenDuringLerp;

			//Perform the actual lerping.  Notice that the first two parameters will always be the same
			//throughout a single lerp-processs (ie. they won't change until we hit the space-bar again
			//to start another lerp)
			oRacket.transform.position = Vector3.Lerp (_startPosition, _endPosition, percentageComplete);

			//When we've completed the lerp, we set _isLerping to false
			if(percentageComplete >= 1.0f)
			{
				_isLerping = false;
			}
		}
	}
	void OnTriggerEnter (Collider other)
	{
		if (other == oSide) {
			StartLerping ();
			Debug.Log ("Entered");
			oTurn = true;
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other == oSide) {
			StartLerping ();
			Debug.Log ("Entered");
			oTurn = false;
		}
	}
}
