using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightcontrol : MonoBehaviour {
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "player") {
			Destroy(this.gameObject);
			GameObject.Find ("Canvas/flashlight").SendMessage ("show");
		}
	}
}
