using UnityEngine;
using System.Collections;

public class EnemyProjectileHit : MonoBehaviour {

	private BulletStats bulletstats;
	private PlayerShipStats shipstats;
	
	void OnTriggerEnter (Collider other) {
		Debug.Log("Collide");
		if(other.CompareTag("Player")){
			Debug.Log ("Player");
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.collider.GetComponent<PlayerShipStats>();
			Debug.Log("Shipstats: " + shipstats.name);
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() - bulletstats.getArmorPen())));
			Debug.Log(shipstats.gameObject);
			Debug.Log (bulletstats.getDamage() * (1 - (shipstats.getArmor() - bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
		
	}
}
