using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	private GameObject player;
	private Transform playertransf;
	private Transform frontlook;
	
	void Start (){
		frontlook = transform;	
		player = GameObject.FindWithTag("Player");
		playertransf = player.GetComponent<Transform>();
		transform.LookAt(playertransf);
	}
	
	void Update () {
		
		transform.LookAt(playertransf);
		
	}
}
