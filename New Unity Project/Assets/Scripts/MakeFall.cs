using UnityEngine;
using System.Collections;

public class MakeFall : MonoBehaviour {

public int forceSetting;

	// Use this for initialization
	void Start () {
			GetComponent<Rigidbody> ().AddForceAtPosition(new Vector3(0,forceSetting,0),new Vector3(0,0,0));
	}
	

	
}
