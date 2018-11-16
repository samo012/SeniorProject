using UnityEngine;
using System.Collections;

public class RayViewerComplete : MonoBehaviour {

    public float weaponRange = 50f;                       // Distance in Unity units over which the Debug.DrawRay will be drawn

	public Transform fpsCam;                                // Holds a reference to the first person camera


	void Start () 
    {
        // Get and store a reference to our Camera by searching this GameObject and its parents
      
	}

	
	void Update () 
    {

        // Draw a line in the Scene View  from the point lineOrigin in the direction of fpsCam.transform.forward * weaponRange, using the color green
		Debug.DrawRay(fpsCam.position, fpsCam.transform.forward * weaponRange, Color.green);
	}
}
