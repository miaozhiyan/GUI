using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class login : MonoBehaviour {
	private GameObject left, medial;
	private GameObject ll;
	private static bool left_is_open = false;
	private static bool medi_is_open = false;
	public AudioClip lo, lc,mo,mc;
	private RaycastHit target;
	// Use this for initialization
	void Start () {
		left = GameObject.Find ("leftdrawer");
		medial = GameObject.Find ("medialdrawer");
		ll = GameObject.Find ("lamblight/Point light");
	}
	
	// Update is called once per frame
	void Update () {

		if (Physics.Raycast (transform.position, Vector3.forward,out target,10)) {
			if (target.collider.gameObject.name == "Cube") {
				print ("this is lamb");
			}
			else if (target.collider.gameObject.tag == "ddd") {
				print ("this is desk");
			}
		}


		if (Input.GetKeyDown (KeyCode.Q)) {
			if (left_is_open == false) {
				left.GetComponent<Animator> ().SetInteger ("left", 1);
				left.GetComponent<AudioSource> ().PlayOneShot (lo);
			} else {
				left.GetComponent<Animator> ().SetInteger ("left",0);
				left.GetComponent<AudioSource> ().PlayOneShot (lc);
			}
			left_is_open = !left_is_open;
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			if (medi_is_open == false) {
				medial.GetComponent<Animator> ().SetInteger ("medial", 1);
				medial.GetComponent<AudioSource> ().PlayOneShot (mo);
			} else {
				medial.GetComponent<Animator> ().SetInteger ("medial",0);
				medial.GetComponent<AudioSource> ().PlayOneShot (mc);
			}
			medi_is_open = !medi_is_open;
		}

		if (Input.GetKeyDown (KeyCode.L)) {
			ll.GetComponent<Light>().enabled =!ll.GetComponent<Light>().enabled;
		}
	}

	void OnGUI()
	{
		GUILayout.Label ("按Q打开左边的抽屉，按E打开中间的抽屉，按L开灯,ESC退出\nMZY缪Bate");
	}
}
