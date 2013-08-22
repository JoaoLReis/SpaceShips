using UnityEngine;
using System.Collections;

public class Moveforward : MonoBehaviour {
	
	public float movement = 1f;
	private Vector3 dest;
	// Use this for initialization
	void Start () {
	
		dest = new Vector3(transform.position.x, transform.position.y, transform.position.z - 100);
		Debug.Log(transform.position.x + "," + transform.position.y + "," + transform.position.z +
					"and " + transform.forward.x + "," + transform.forward.y + "," + transform.forward.z);
			
		
	}
	
	// Update is called once per frame
	void Update () {
		
		dest = new Vector3(transform.position.x, transform.position.y, transform.position.z + 100);

		moveForward();
	}
	
	void moveForward(){
		
		transform.position = Vector3.MoveTowards(transform.position, dest, movement *Time.deltaTime);
				
	}
}
