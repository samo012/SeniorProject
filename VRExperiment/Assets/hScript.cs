using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hScript : MonoBehaviour {
	public OVRGrabber grabber;

	void Start () {
		//abber.GetComponent<OVRGrabber> ().
	

	}
	
	// Update is called once per frame
	void Update () {
		
		if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
		{/*
			Vector3 handPos = OVRInput.GetLocalControllerPosition(m_controller);
			Quaternion handRot = OVRInput.GetLocalControllerRotation(m_controller);
			Vector3 destPos = m_parentTransform.TransformPoint(m_anchorOffsetPosition + handPos);
			Quaternion destRot = m_parentTransform.rotation * handRot * m_anchorOffsetRotation;
			GetComponent<Rigidbody>().MovePosition(destPos);
			GetComponent<Rigidbody>().MoveRotation(destRot);
*/


		}
	}
}
