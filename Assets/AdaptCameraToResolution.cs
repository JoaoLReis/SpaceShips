using UnityEngine;
using System.Collections;

public class AdaptCameraToResolution : MonoBehaviour {
	
	private Transform _leftofship;
	//private Transform _rightofship;
	private Transform _shipcollider;
	private Transform _cameralookat;
	
	void Start () {
	
		int sidemargin = Screen.width/20;
		int bottommargin = Screen.height/10;
		
		_leftofship = GameObject.Find("LeftOfShip").GetComponent<Transform>();
		//_rightofship = GameObject.Find("RightOfShip").GetComponent<Transform>();
		_shipcollider = GameObject.Find("ShipCollider").GetComponent<Transform>();
		_cameralookat = GameObject.Find("CameraLookAt").GetComponent<Transform>();
		
		
		while(camera.WorldToScreenPoint(_leftofship.position).x < sidemargin){
			transform.Translate(-transform.forward);
			transform.LookAt(_cameralookat);
		}
		
		while(camera.WorldToScreenPoint(_shipcollider.position).y > bottommargin || camera.WorldToScreenPoint(_shipcollider.position).y < bottommargin-5){
			if(camera.WorldToScreenPoint(_shipcollider.position).y > bottommargin)
				transform.Translate(transform.up);
			if(camera.WorldToScreenPoint(_shipcollider.position).y < bottommargin-5)
				transform.Translate(-transform.up);
			transform.LookAt(_cameralookat);
		}
		
		camera.farClipPlane = camera.WorldToScreenPoint(_cameralookat.position).z;
		
		Debug.Log(camera.WorldToScreenPoint(_leftofship.position));
		Debug.Log(camera.WorldToScreenPoint(_shipcollider.position));
		Debug.Log(camera.WorldToScreenPoint(_cameralookat.position));
		Debug.Log(Screen.width);
		Debug.Log(Screen.height);
		/*Debug.Log("1 " + camera.WorldToScreenPoint(_leftofship.position).x + "<" + sidemargin);
		transform.Translate(-transform.forward);	
		Debug.Log("2 " + camera.WorldToScreenPoint(_leftofship.position).x + "<" + sidemargin);
		transform.Translate(-transform.forward);
		
		Debug.Log("3 " + camera.WorldToScreenPoint(_shipcollider.position).y + ">" + bottommargin);
		transform.Translate(transform.up);
		Debug.Log("4 " + camera.WorldToScreenPoint(_shipcollider.position).y + ">" + bottommargin);
		transform.Translate(transform.up);  */
		
		
		
	}
	
	void Update () {
	
	}
}
