using UnityEngine;
using System.Collections;

public class ThirdPerson : MonoBehaviour {
	
	public Transform target;
	public float speed = 0f;
	private Vector3 destination;
	
	
	// Update is called once per frame
	void Update () {
		
		destination = new Vector3(transform.position.x, transform.position.y, transform.position.z + 100f);
		
		//transform.LookAt(target.position + target.forward);
		
		transform.position = Vector3.Lerp(transform.position, destination, speed *Time.deltaTime);
		
		
		
	}
}
