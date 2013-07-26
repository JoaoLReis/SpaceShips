using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
	
	
	void OnTriggerEnter (Collider other) {
		if(other.CompareTag("PlayerShot")){
			BulletStats comp = other.GetComponent<BulletStats>();
			BasicShipStats stats = GetComponentInChildren<BasicShipStats>();
			stats.decreaseHealth(comp.getDamage() * (1 - (stats.getArmor() * comp.getArmorPen())));
		}
	}
	
}
