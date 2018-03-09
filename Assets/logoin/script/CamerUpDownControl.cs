using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerUpDownControl : MonoBehaviour {
	Vector3 SCREEN_CENTER,lerpVector;
	// Use this for initialization
	void Start () {
		SCREEN_CENTER.y = Screen.height / 2;
	}

	void Update () {
		lerpVector.x = SCREEN_CENTER.y-Input.mousePosition.y;

		if (lerpVector.x < 0) {
			if (transform.localEulerAngles.x <= 70 || transform.localEulerAngles.x > 300) {
				transform.Rotate (lerpVector * Time.deltaTime/2);
			}
		}
		else if(lerpVector.x > 0){
			if (transform.localEulerAngles.x < 60 || transform.localEulerAngles.x >= 290) {
				transform.Rotate (lerpVector * Time.deltaTime/2);
			}
		}
			
	}
}