using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
	
	private PlayerShipStats stats;
	private float health;
	
	void Start(){
		
		stats = GameObject.FindWithTag("Player").GetComponent<PlayerShipStats>();
		Debug.Log("Start");
		
	}
	
	void OnGUI(){
		
		health = stats.getHealth();
		
		GUI.Box (new Rect(0, Screen.height - 50, 100, 25), "Health:" + health);
		
		
	}
}