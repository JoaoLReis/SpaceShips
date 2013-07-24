using UnityEngine;
using System.Collections;

public class BasicShipStats : MonoBehaviour {
	
	private float health = 4;
	private float armor = 0;
	
	public float getHealth(){
		return health;
	}
	
	public float getArmor(){
		return armor;
	}
	
	public void decreaseHealth(float damage){
		health -= damage;
		if(health <= 0){
			Destroy (gameObject);
		}
	}
}