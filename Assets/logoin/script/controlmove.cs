using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlmove : MonoBehaviour {
	float x,y;
	Vector3 SCREEN_CENTER,lerpVector;
	void Start()
	{
		SCREEN_CENTER.x = Screen.width / 2;
	}
	// Update is called once per frame
	void Update () {
		Rotate ();
		Move ();
		Jump ();
	}
	void Jump()
	{
		if (Input.GetKey (KeyCode.Space)) {
			gameObject.GetComponent<Rigidbody> ().AddForce(transform.up*20);
		}
	}
	void Rotate()
	{
		lerpVector.y = (Input.mousePosition.x-SCREEN_CENTER.x);
		if (lerpVector.y >= 100) {
			lerpVector.y = 100;
		} else if (lerpVector.y <= -100) {
			lerpVector.y = -100;
		}
		transform.Rotate (lerpVector * Time.deltaTime);
		/*if (lerpVector.y > 220) {
			lerpVector.y = 40;
			transform.Rotate (lerpVector * Time.deltaTime);
		} 
		else if (lerpVector.y < -220) {
			lerpVector.y = -40;
			transform.Rotate (lerpVector * Time.deltaTime);
		}*/

	}
	void Move()
	{
		x = Input.GetAxis ("Horizontal")*Time.deltaTime*3;
		y = Input.GetAxis ("Vertical")*Time.deltaTime*3;
		transform.Translate (x,0,y);
	}
		
}
