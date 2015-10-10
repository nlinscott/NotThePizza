using UnityEngine;
using System.Collections;

public class MakeFall : MonoBehaviour {

	public Vector2 pivot;

	// Use this for initialization
	void Start () {
			GetComponent<Rigidbody> ().AddForceAtPosition(new Vector3(0,-1000,0),new Vector3(0,0,0));
	}
	

	
}
