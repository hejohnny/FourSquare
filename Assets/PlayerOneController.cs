using UnityEngine;
using System.Collections;

public class PlayerOneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Fixed Update is called every __ seconds, Edit Project Settings Time Fixed TimeStamp
	//Movement
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.W)){
			GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().forward *2f, ForceMode.VelocityChange);
		}

		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().right *2f, ForceMode.VelocityChange);
			//transform.Rotate(new Vector3(0f,-5f,0f));
		}
		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().right *-2f, ForceMode.VelocityChange);
			//.Rotate(new Vector3(0f,5f,0f));
		}

		//transform.position = GetComponent<Transform>
		Ray ray = new Ray (transform.position, -Vector3.up);
		//to know where and what the raycast hit , we have to store that impact info
		RaycastHit rayHit = new RaycastHit (); //Blank Container for Info
		
		if (Physics.Raycast (ray, out rayHit, 1.1f)) 
		{
			if (Input.GetKey (KeyCode.LeftShift)) 
			{
				GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, 5000f, 0f), ForceMode.Acceleration);
				Debug.Log (rayHit.point);
				//Destroy (rayHit.collider.gameObject);
			}
		}
		

	
	}
}
