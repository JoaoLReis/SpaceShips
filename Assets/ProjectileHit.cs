using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
	private BulletStats bulletstats;
	private BasicShipStats shipstats;
	
	void OnTriggerEnter (Collider other) {
		
		if(other.CompareTag("Enemy")){
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.GetComponent<BasicShipStats>();
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() * bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
	}
	
	
}
