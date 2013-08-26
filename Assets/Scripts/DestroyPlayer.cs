using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour {

	private PlayerShipStats shipstats;
	//private GameObject deathanim;
	
	// Use this for initialization
	void Start () {
		shipstats = GetComponent<PlayerShipStats>();
		//deathanim = (GameObject) Resources.Load("DeathAnimation");
		//Debug.Log(deathanim);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(shipstats.getHealth() < 0){
			//GameObject death;
			//death = Instantiate(deathanim, transform.position, transform.rotation) as GameObject;
			//death.particleSystem.Play();
			Destroy(gameObject);	
		}
		
		
	}
}
