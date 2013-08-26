using UnityEngine;
using System.Collections;

public class Actions : MonoBehaviour {
	
	public float jumpheight = 45f;
	public float gravity = -10.8f;
	public float fallspeed = 1f;
	public float Vspeed = 0f;
	private int numjumps = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		bool downSpace = Input.GetKeyDown(KeyCode.Space);
        //bool heldSpace = Input.GetKey(KeyCode.Space);
        //bool upSpace = Input.GetKeyUp(KeyCode.Space);
		
		CharacterController controller = GetComponent<CharacterController>();
		
		if(downSpace && numjumps<2){
			Vspeed = 1;
			numjumps++;
		}
				

		controller.Move(transform.up * (jumpheight * Vspeed) * Time.deltaTime);
		Vspeed += (gravity/2) * Time.deltaTime;
		
		if(controller.isGrounded){
			Vspeed = 0f;	
			numjumps = 0;
			
		}
	}
	
}
