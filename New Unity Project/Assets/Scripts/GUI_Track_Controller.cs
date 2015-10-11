using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUI_Track_Controller : MonoBehaviour {

	public GameObject leftTrack = null;
	public GameObject rightTrack = null;
	public GameObject straightTrack = null;
	public GameObject bridge = null;
	private GameObject startingObject = null;

	public float moveSpeed;

	public float rotationSpeed;

	private List<GameObject> list = new List<GameObject>();

	private MovableGameObject currentObject;
	
	private void Update(){
		if(currentObject != null){

			if(Input.GetKey(KeyCode.R)){
				currentObject.rotateX();

			}else{

				if (Input.GetKey (KeyCode.LeftArrow)) {
					
					currentObject.translateLeftX();
				}
				if (Input.GetKey (KeyCode.RightArrow)) {
					
					currentObject.translateRightX();
				}

				if(Input.GetKey(KeyCode.UpArrow)){
					currentObject.translateForwardZ();
				}

				if(Input.GetKey(KeyCode.DownArrow)){
					currentObject.translateBackZ();
				}
			}
		}
	}

	protected void createNewItem(GameObject track){
		if(track != null){
			
			GameObject temp = (GameObject)Instantiate(track);
			currentObject = new MovableGameObject(temp, moveSpeed, rotationSpeed);
			
			list.Add(temp);
			
		}
	}

	protected void removeItem(){

		if( list.Count > 1){
			
			GameObject obj = list[list.Count - 1];
			Destroy (obj);
			list.Remove(obj);
			GameObject latest = list[list.Count - 1];
			
			currentObject = new MovableGameObject(latest, moveSpeed, rotationSpeed);
			
		}else if(list.Count == 1){
			
			GameObject obj = list[list.Count - 1];
			Destroy (obj);
			list.Remove(obj);
			
			currentObject = null;
		}
	}

	private void OnGUI()
	{

		if (GUI.Button (new Rect (10, 10, 100, 30), "+ Left Turn")) {

			createNewItem(leftTrack);

		} else if (GUI.Button (new Rect (10, 45, 100, 30), "+ Right Turn")) {

			createNewItem(rightTrack);

		} else if (GUI.Button (new Rect (10, 80, 100, 30), "+ Straight Path")) {

			createNewItem(straightTrack);
			
		} else if (GUI.Button (new Rect (10, 115, 100, 30), "+ Bridge")) {

			createNewItem(bridge);
			
		} else if (GUI.Button (new Rect (10, 150, 100, 30), "- Undo Last")) {

			removeItem();
		
		} else if (GUI.Button (new Rect (10, 185, 40, 40), "Go!")) {
			 GameObject.Find("Domino (14)").GetComponent<Rigidbody> ().AddForceAtPosition(new Vector3(0,-15f,0),new Vector3(0,0,0));
		} 
	}
}
