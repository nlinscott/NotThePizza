using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUI_Buttons : MonoBehaviour {
	
	private void OnGUI()
	{		
		if(GUI.Button (new Rect (10, 80, 100, 30), "Go Back"))
		{
			Application.LoadLevel(0);
		}
	}

}
