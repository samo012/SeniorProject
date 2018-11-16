using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vSpeed : MonoBehaviour {

	public OVRPlayerController player;
	public float speed =0.1f;
	void Start()
	{
		player.GetComponent<OVRPlayerController> ().Acceleration = speed;
		Time.timeScale=2.0f;


	}

  void FixedUpdate ()
  {
		player.GetComponent<OVRPlayerController> ().Acceleration = speed;
		if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
      {
			speed = speed + 0.1f;

      }
		else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown))
      {
			speed = speed - 0.1f;
      }
  


      if (OVRInput.Get(OVRInput.Button.One)){
			Debug.Log(speed);
      }

      
  }
}