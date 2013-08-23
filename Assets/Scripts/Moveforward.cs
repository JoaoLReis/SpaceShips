using UnityEngine;
using System.Collections;

public class Moveforward : MonoBehaviour {
	
	public float movement = 35f;
	private Vector3 dest;
	// Use this for initialization
	void Start () {
	
		dest = new Vector3(transform.position.x, transform.position.y, transform.position.z - 100);
			
		
	}
	
	// Update is called once per frame
	void Update () {
		
		dest = new Vector3(transform.position.x, transform.position.y, transform.position.z - 100);

		moveForward();
	}
	
	void moveForward(){
		
		transform.position = Vector3.MoveTowards(transform.position, dest, movement *Time.deltaTime);
				
	}
}
