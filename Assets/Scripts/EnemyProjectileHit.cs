using UnityEngine;
using System.Collections;

public class EnemyProjectileHit : MonoBehaviour {

	private BulletStats bulletstats;
	private PlayerShipStats shipstats;
	
	void OnTriggerEnter (Collider other) {
		Debug.Log(gameObject + " Collide with " + other.name);
		if(other.CompareTag("Player")){
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.collider.GetComponent<PlayerShipStats>();
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() - bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
		
	}
}
