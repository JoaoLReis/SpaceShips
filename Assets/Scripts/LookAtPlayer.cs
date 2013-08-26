using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	private GameObject player;
	private Transform playertransf;
	//private Transform lookahead;
	
	void Start (){
		//lookahead = transform;	
		player = GameObject.FindWithTag("Player");
		playertransf = player.GetComponent<Transform>();
		transform.LookAt(playertransf);
	}
	
	void Update () {
		
		transform.LookAt(playertransf);
		
	}
}
