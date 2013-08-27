using UnityEngine;
using System.Collections;

public class ShootTurret : MonoBehaviour {
	
	
	public Rigidbody bulletPrefab;
    public Transform barrelEndLeft;
    public Transform barrelEndRight;
	public float attackspeed = 1.25f;
	public float timer = 0f;
	
	
	// Update is called once per frame
	void Update () {
		
		float actualtime = Time.time;
		
		if(actualtime > timer + attackspeed){
			FireWeapon();
			timer = actualtime;
		}
		
	}
	
	void FireWeapon(){
            
		Rigidbody bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, barrelEndLeft.position, barrelEndLeft.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndLeft.forward * 10000);
		bulletInstance = Instantiate(bulletPrefab, barrelEndRight.position, barrelEndRight.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndRight.forward * 10000);
		
		
	}
}
