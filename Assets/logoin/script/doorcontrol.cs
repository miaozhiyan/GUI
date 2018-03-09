using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class doorcontrol : MonoBehaviour {
	private bool opened=false;
	private Vector3 axis;
	void Start()
	{
		axis = transform.position;
		axis.z = axis.z - 0.7f;
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "player") {
			if (opened==false) {
				transform.RotateAround (axis,new Vector3(0,1,0),90);
				opened = !opened;
			} else if(opened==true){
				transform.RotateAround (axis,new Vector3(0,1,0),-90);
				opened=!opened;
			}
		}
	}
}
