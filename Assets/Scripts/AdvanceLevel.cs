using UnityEngine;
using System.Collections;

public class AdvanceLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(-transform.forward * Time.deltaTime * 5);
		
		
	}
}
