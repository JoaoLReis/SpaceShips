using UnityEngine;
using System.Collections;

public class DestroyShip : MonoBehaviour {
	
	private ShipStats shipstats;
	private GameObject deathanim;
	
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 30);
		shipstats = GetComponent<ShipStats>();
		deathanim = (GameObject) Resources.Load("DeathAnimation");
	}
	
	// Update is called once per frame
	void Update () {
	
		if(shipstats.getHealth() < 0){
			GameObject death;
			death = Instantiate(deathanim, transform.position, transform.rotation) as GameObject;
			death.particleSystem.Play();
			Destroy(gameObject);	
		}
		
		
	}
}
