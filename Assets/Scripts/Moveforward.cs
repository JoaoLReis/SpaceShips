using UnityEngine;
using System.Collections;

public class Moveforward : MonoBehaviour {
	
	public float movement = 0f;
	public float sidemovement = 100f;
	private Vector3 destination;
	private float leftpos = -75;
	private float rightpos = 75;
	private Vector3 maxleft;
	private Vector3 maxright;
	
	
	// Use this for initialization
	void Start () {
	
		destination = new Vector3(transform.position.x, transform.position.y, transform.position.z + 100);
	}
	
	// Update is called once per frame
	void Update () {
		
		bool downright = Input.GetKeyDown(KeyCode.D);
        bool heldright = Input.GetKey(KeyCode.D);
    //    bool upright = Input.GetKeyUp(KeyCode.D);
		
		bool downleft = Input.GetKeyDown(KeyCode.A);
        bool heldleft = Input.GetKey(KeyCode.A);
     //   bool upleft = Input.GetKeyUp(KeyCode.A);
		
		float posz = transform.position.z;
		
		maxleft = new Vector3(leftpos, 0, posz);
		maxright = new Vector3(rightpos, 0, posz);
		
		destination = new Vector3(transform.position.x, transform.position.y, transform.position.z + 100);
		
		
		if(downleft || heldleft){
    
	      	transform.position = Vector3.MoveTowards(transform.position, maxleft, sidemovement *Time.deltaTime);
		
		}
		
		if(downright || heldright){
		
			transform.position = Vector3.MoveTowards(transform.position, maxright, sidemovement *Time.deltaTime);
		
		}
		
		moveForward();
	}
	
	void moveForward(){
		
		
		transform.position = Vector3.Lerp(transform.position, destination, movement *Time.deltaTime);
		
		
	}
}
