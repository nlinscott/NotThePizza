using UnityEngine;
using System.Collections;

public class BeginPush : MonoBehaviour {

	public float thrust;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (transform.up * thrust);

	}
	
		void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Domino") {

			Destroy(gameObject);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
