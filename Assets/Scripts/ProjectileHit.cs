using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
	private BulletStats bulletstats;
	private ShipStats shipstats;
	
	void OnCollisionEnter (Collision other) {
		Debug.Log("Collide");
		if(other.collider.CompareTag("Enemy")){
			Debug.Log ("IF");
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.collider.GetComponent<ShipStats>();
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() * bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
		
	}
	
	
}
