using UnityEngine; // we use namespaces called unityEngine and System
using System;// the namespace contains classes

public class ClockAnimator : MonoBehaviour { // the class clockAnimator inherits from monobehavior 



	private const float   // constant variables declared ( variables that dont change)
		hoursToDegree = 360/12f, 
		minutesToDegree = 360/60f,
		secondsToDegree = 360/60f;

	public Transform hours, minutes, seconds;

	public bool analog;


	void Update () {

		if (analog) {

		}

		else {

		DateTime time = DateTime.Now;

		hours.localRotation = Quaternion.Euler(0f,0f,time.Hour* - hoursToDegree);
		minutes.localRotation = Quaternion.Euler(0f,0f,time.Minute* - minutesToDegree);
		seconds.localRotation = Quaternion.Euler(0f,0f,time.Second* - secondsToDegree);

		
		}
	
	}


}