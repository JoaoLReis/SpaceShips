using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float movement = 100f;
	private float leftpos = -75;
	private float rightpos = 75;
	private float frontpos = 50;
	private float backpos = 0;
	private Vector3 maxleft;
	private Vector3 maxright;
	private Vector3 maxback;
	private Vector3 maxfront;
	
	// Update is called once per frame
	void Update () {
		
		bool downright = Input.GetKeyDown(KeyCode.D);
        bool heldright = Input.GetKey(KeyCode.D);
		
		bool downleft = Input.GetKeyDown(KeyCode.A);
        bool heldleft = Input.GetKey(KeyCode.A);
		
		bool downfront = Input.GetKeyDown(KeyCode.W);
        bool heldfront = Input.GetKey(KeyCode.W);
		
		bool downback = Input.GetKeyDown(KeyCode.S);
        bool heldback = Input.GetKey(KeyCode.S);
		
		float posz = transform.position.z;
		float posx = transform.position.x;
		
		maxleft = new Vector3(leftpos, 0, posz);
		maxright = new Vector3(rightpos, 0, posz);
		maxback = new Vector3(posx, 0, backpos);
		maxfront = new Vector3(posx, 0, frontpos);
	
		
		
		if(downfront || heldfront){
    
	      	transform.position = Vector3.MoveTowards(transform.position, maxfront, movement *Time.deltaTime);
		
		}
		
		if(downback || heldback){
		
			transform.position = Vector3.MoveTowards(transform.position, maxback, movement *Time.deltaTime);
		
		}
		
		if(downleft || heldleft){
    
	      	transform.position = Vector3.MoveTowards(transform.position, maxleft, movement *Time.deltaTime);
		
		}
		
		if(downright || heldright){
		
			transform.position = Vector3.MoveTowards(transform.position, maxright, movement *Time.deltaTime);
		
		}
		
		
	}
	

}
