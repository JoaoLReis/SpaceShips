using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
	
	private PlayerShipStats stats;
	private float health;
	
	void Start(){
		
		stats = GameObject.FindWithTag("Player").GetComponent<PlayerShipStats>();
		
	}
	
	void OnGUI(){
		
		health = stats.getHealth();
		
		GUI.Box (new Rect(0, 0, 70, 25), "Health:" + health);
		
		
	}
}
