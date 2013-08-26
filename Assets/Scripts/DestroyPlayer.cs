using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour {

	private PlayerShipStats shipstats;
	private DeathAnim deathanim;
	private bool control = true;
	
	
	// Use this for initialization
	void Start () {
		shipstats = GetComponent<PlayerShipStats>();
		deathanim = GetComponentInChildren<DeathAnim>();
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(shipstats.getHealth() < 0.1f && control){
			GetComponent<MeshCollider>().enabled = false;
			deathanim.anim();
			Destroy(GameObject.Find("SpaceShip"),2);
			Destroy(GetComponent<PlayerMovement>(), 2);
			Destroy(gameObject,5);	
			control = false;
		}
		
		
	}
	
	
}
