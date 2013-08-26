using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
	private BulletStats bulletstats;
	private ShipStats shipstats;
	
	void OnTriggerEnter (Collider other) {
		Debug.Log("Collide");
		if(other.CompareTag("Enemy")){
			Debug.Log ("Enemy");
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.collider.GetComponent<ShipStats>();
			Debug.Log("Shipstats: " + shipstats.name);
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() - bulletstats.getArmorPen())));
			Debug.Log(shipstats.gameObject);
			Debug.Log (bulletstats.getDamage() * (1 - (shipstats.getArmor() - bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
		
	}
	
	
}
