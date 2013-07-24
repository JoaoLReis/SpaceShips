using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

	public float rotationspeed = 5f;
	public Transform leftmarker;
	public Transform rightmarker;
	public Transform upmarker;
	
	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		
		bool downright = Input.GetKeyDown(KeyCode.D);
        bool heldright = Input.GetKey(KeyCode.D);
       // bool upright = Input.GetKeyUp(KeyCode.D);
		
		bool downleft = Input.GetKeyDown(KeyCode.A);
        bool heldleft = Input.GetKey(KeyCode.A);
       // bool upleft = Input.GetKeyUp(KeyCode.A);
		
		
		if(downleft || heldleft){
    
	      	transform.rotation = Quaternion.Lerp(transform.rotation, leftmarker.rotation, rotationspeed * Time.deltaTime);
			
		//	transform.RotateAround(transform.forward, rotationside * Time.deltaTime );
		//	transform.position = Vector3.Lerp(transform.position, positionleft, movement *Time.deltaTime);
		
		}
		if(downright || heldright){
		
			transform.rotation = Quaternion.Lerp(transform.rotation, rightmarker.rotation, rotationspeed * Time.deltaTime);
			//transform.RotateAround(transform.forward, -rotationspeed *Time.deltaTime);
		
		}
		
		transform.rotation = Quaternion.Lerp(transform.rotation, upmarker.rotation, rotationspeed * Time.deltaTime);
				
		
	}
	
}
