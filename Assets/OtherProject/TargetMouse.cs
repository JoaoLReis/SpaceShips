using UnityEngine;
using System.Collections;

public class TargetMouse : MonoBehaviour {
	
	// speed is the rate at which the object will rotate
	public float speed = 1f;
	
	void Update () 
	{
		
		Vector3 forwardplane = transform.position;
		forwardplane.Set(transform.position.x, transform.position.y, transform.position.z + 300);
		
    	// Generate a plane that intersects the transform's position with an upwards normal.
 		Plane playerPlane = new Plane(Vector3.forward, forwardplane);
		
    	// Generate a ray from the cursor position
    	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
    	// Determine the point where the cursor ray intersects the plane.
    	// This will be the point that the object must look towards to be looking at the mouse.
    	// Raycasting to a Plane object only gives us a distance, so we'll have to take the distance,
    	//   then find the point along that ray that meets that distance.  This will be the point
    	//   to look at.
    	float hitdist = 0.0f;
		RaycastHit hit;
		
    	// If the ray is parallel to the plane, Raycast will return false.
    	if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
		{
			Debug.Log("plane");
        	// Get the point along the ray that hits the calculated distance.
        	Vector3 targetPoint = hit.point;
 
        	// Determine the target rotation.  This is the rotation if the transform looks at the target point.
        	Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
 
        	// Smoothly rotate towards the target point.
        	transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.time);
		}
		
		else{
			
			playerPlane.Raycast (ray, out hitdist);
			
			Vector3 targetPoint = ray.GetPoint(hitdist);
 
        	// Determine the target rotation.  This is the rotation if the transform looks at the target point.
        	Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
 
        	// Smoothly rotate towards the target point.
        	transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.time);
		}
		
		
    }
	
}
