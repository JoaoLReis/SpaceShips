using UnityEngine;
using System.Collections;

public class PlayerShipStats : MonoBehaviour {

	protected float health;
	protected float armor;
	
	
	public PlayerShipStats (){
		health = 50;
		armor = 0;
		
	}
	
	public float getHealth(){
		return health;
	}
	
	public float getArmor(){
		return armor;
	}
	
	public void decreaseHealth(float damage){
		Debug.Log("Decrease" + damage);
		health -= damage;		
	}
}
