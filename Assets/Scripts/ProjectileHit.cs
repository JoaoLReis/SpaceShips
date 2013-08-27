using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
	private BulletStats bulletstats;
	private ShipStats shipstats;
	
	void OnTriggerEnter (Collider other) {
		Debug.Log(gameObject + " Collide with " + other.name);
		if(other.CompareTag("Enemy")){
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.collider.GetComponent<ShipStats>();
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() - bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
		
	}
	
	
}
