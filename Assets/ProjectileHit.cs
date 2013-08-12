using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
	private BulletStats bulletstats;
	private BasicShipStats shipstats;
	
	void OnCollisionEnter (Collision other) {
		Debug.Log("Collide");
		if(other.collider.CompareTag("Enemy")){
			Debug.Log ("IF");
			bulletstats = GetComponent<BulletStats>();
			shipstats = other.collider.GetComponent<BasicShipStats>();
			shipstats.decreaseHealth(bulletstats.getDamage() * (1 - (shipstats.getArmor() * bulletstats.getArmorPen())));
			Destroy(gameObject);
		}
		
	}
	
	
}
