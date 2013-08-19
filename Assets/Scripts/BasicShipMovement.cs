using UnityEngine;
using System.Collections;

public class BasicShipMovement : MonoBehaviour {


	public float movement = 50f;
	public float rotationspeed = 0.025f;
	private Vector3 destination;
	public float moveDirection;
	private Vector3 newrotation;
	
	
	
	// Use this for initialization
	void Start () {
		if(transform.position.x > 0)
			moveDirection = 1f;
		if(transform.position.x < 0)
			moveDirection = -1f;
		if(transform.position.x == 0)
			moveDirection = 0f;
		newrotation = new Vector3(0, rotationspeed*moveDirection, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		newrotation = new Vector3(0, rotationspeed*moveDirection, 0);
		
		rotate();
		moveForward();
	}
	
	void moveForward(){
		
		
		transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward, movement *Time.deltaTime);
		
		
	}
	
	void rotate(){
		
		transform.Rotate(newrotation);
		//transform.rotation = Quaternion.AngleAxis(5f *moveDirection, transform.up);

		
	}
	
}
