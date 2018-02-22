//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateCamera : MonoBehaviour {

	//constantly rotates
	void FixedUpdate () 
	{
		transform.Rotate(Vector3.up * Time.deltaTime);	
	}
}
