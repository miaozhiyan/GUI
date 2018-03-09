using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gui : MonoBehaviour {
	private Rect windowRect = new Rect(70, 70, 150, 100);
	private bool win = false;
	public GUISkin askin;
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			win = !win;
		}
	}
	void OnGUI()
	{
		GUI.skin = askin;
		if (win) {
			
			windowRect = GUI.Window (0, windowRect, WindowContain, "My Window");
		}
		
	}


	void WindowContain(int id)
	{
		if (GUI.Button (new Rect (15, 30, 100, 20), "退出游戏")) {
			Application.Quit ();
		}

		GUI.DragWindow (new Rect(0,0,200,200));
	}
}
