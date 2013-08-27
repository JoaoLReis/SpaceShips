using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

	public float rotationspeed = 5f;
	private Quaternion leftRot;
	private Quaternion rightRot;
	
	void Start(){
		
		leftRot = Quaternion.Euler(0,0,45);
		rightRot = Quaternion.Euler(0,0,315);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		bool downright = Input.GetKeyDown(KeyCode.D);
        bool heldright = Input.GetKey(KeyCode.D);
		
		bool downleft = Input.GetKeyDown(KeyCode.A);
        bool heldleft = Input.GetKey(KeyCode.A);
		
		
		if(downleft || heldleft){
    
	      	transform.rotation = Quaternion.Lerp(transform.rotation, leftRot, rotationspeed * Time.deltaTime);
		
		}
		if(downright || heldright){
		
			transform.rotation = Quaternion.Lerp(transform.rotation, rightRot, rotationspeed * Time.deltaTime);
		
		}
		
		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, rotationspeed * Time.deltaTime);
				
		
	}
	
	private Transform FindChild(string name){
		Transform[] trans = GetComponentsInChildren<Transform>();
		
		foreach(Transform t in trans){
			if(t.gameObject.name.Equals(name))
				return t;
		}		
		return null;
	}
	
}
