using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

	public GameObject S1Cam, S2Cam, S3Cam;

	int curCam = 1;

	void Update()
	{
		if (OVRInput.GetDown(OVRInput.Button.One))
		{
			
			if (curCam == 1){
				S1Cam.gameObject.SetActive(true);
				S2Cam.gameObject.SetActive(false);
				S3Cam.gameObject.SetActive(false);
				curCam = 2;
			}
			if (curCam == 2){
				S1Cam.gameObject.SetActive(false);
				S2Cam.gameObject.SetActive(true);
				S3Cam.gameObject.SetActive(false);
			}
			if (curCam == 3){
				S1Cam.gameObject.SetActive(false);
				S2Cam.gameObject.SetActive(false);
				S3Cam.gameObject.SetActive(true);
				curCam = 0;
			}
		}
	}
}

