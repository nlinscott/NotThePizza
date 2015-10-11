using UnityEngine;
using System.Collections;

public class MovableGameObject {

	private GameObject editableObject;

	private float moveSpeed;
	private float rotationSpeed;

	public MovableGameObject(GameObject obj, float move, float rotation){
		editableObject = obj;
		moveSpeed = move;
		rotationSpeed = rotation;
	}

	public void rotateX(){
		editableObject.transform.Rotate (Vector3.up, rotationSpeed * Time.deltaTime);
	}

	public void translateLeftX(){
		editableObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
	}
	public void translateRightX(){
		editableObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
	}
	public void translateForwardZ(){

		editableObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
	public void translateBackZ(){
		
		editableObject.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
	}
}
