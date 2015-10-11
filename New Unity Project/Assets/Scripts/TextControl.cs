using UnityEngine;
using System.Collections;

public class TextControl : MonoBehaviour {


	public bool isDemoButton = true;

	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.green;
	}

	void OnMouseExit()
	{
		GetComponent<Renderer> ().material.color = Color.white;
	}

	void OnMouseUp()
	{
		if (isDemoButton) {
			Application.LoadLevel(2);
		} else {
			Application.LoadLevel(1);
		}
	}



}
