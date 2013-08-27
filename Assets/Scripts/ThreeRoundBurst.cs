using UnityEngine;
using System.Collections;

public class ThreeRoundBurst : MonoBehaviour {

	public Rigidbody bulletPrefab;
    public Transform barrelEnd;
	public float attackspeed = 2.50f;
	public float timer = 0f;
	
	
	// Update is called once per frame
	void Update () {
		
		
		float actualtime = Time.time;
		
		if(actualtime > timer + attackspeed){
			FireWeapon();
			Invoke ("FireWeapon", 0.2f);
			Invoke ("FireWeapon", 0.4f);
			timer = actualtime;
		}
		
		
	}
	
	void FireWeapon(){
            
		Rigidbody bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEnd.forward * 7500);
		
	}
}
