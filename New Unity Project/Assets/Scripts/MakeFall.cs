using UnityEngine;
using System.Collections;

public class MakeFall : MonoBehaviour {

	public Vector2 pivot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space"))
            GetComponent<Rigidbody> ().AddForceAtPosition(new Vector3(0,-20,0),new Vector3(0,0,0));        
    }
	
}
