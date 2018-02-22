using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public Camera cam;

	public KeyCode key;

	//sets cursorstate
	void Awake () 
	{
		Cursor.lockState = CursorLockMode.Locked;
	}
	// Update is called once per frame
	void Update () 
	{
		Shoot();
	}
	public void Shoot () 
	{
		RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Input.GetKeyDown(key))
		{
			if (Physics.Raycast(ray, out hit)) 
			{
            	GameObject objectHit = hit.collider.gameObject; //what you hit
				Destroy(objectHit);

				Debug.Log(hit.collider.gameObject.name); //print name of hit target
			}
		} 
	}
}
