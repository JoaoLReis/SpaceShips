using UnityEngine;
using System.Collections;


public class ShipStats : MonoBehaviour{
	
	protected float health;
	protected float armor;
	
	public ShipStats (){
		health = 0;
		armor = 0;
		
	}
	
	public float getHealth(){
		return health;
	}
	
	public float getArmor(){
		return armor;
	}
	
	public virtual void decreaseHealth(float damage){}
	
}


