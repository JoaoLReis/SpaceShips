using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float sidemovement = 100f;
	private float leftpos = -75;
	private float rightpos = 75;
	private Vector3 maxleft;
	private Vector3 maxright;
	
	
	// Use this for initialization
	void Start () {
	
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
		
		
		
		if(downleft || heldleft){
    
	      	transform.position = Vector3.MoveTowards(transform.position, maxleft, sidemovement *Time.deltaTime);
		
		}
		
		if(downright || heldright){
		
			transform.position = Vector3.MoveTowards(transform.position, maxright, sidemovement *Time.deltaTime);
		
		}
		
	}
	

}
