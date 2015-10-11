using UnityEngine;
using System.Collections;
using System.Threading;

public class ChangeCameraTrigger : MonoBehaviour{

	public Camera povCamera;
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("StartTrigger")){
			switchCameras ();
		}
	}

	
	private void switchCameras ()
	{
		povCamera.enabled = true;
	}
}
