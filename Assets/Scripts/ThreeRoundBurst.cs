using UnityEngine;
using System.Collections;

public class ThreeRoundBurst : MonoBehaviour {
	
	public float attackspeed = 3.50f;
	public float timer = 0f;
	private Transform barrelEnd;
	private Rigidbody bulletPrefab;
	
	void Start(){
		GameObject bullet;
		barrelEnd = FindChild("BarrelEnd");
		bullet = (GameObject) Resources.Load("SimpleBullet");
		bulletPrefab = bullet.GetComponent<Rigidbody>();
	}
	
	
	// Update is called once per frame
	void Update () {
		
		
		float actualtime = Time.time;
		
		if(actualtime > timer + attackspeed){
			FireWeapon();
			Invoke ("FireWeapon", 0.4f);
			Invoke ("FireWeapon", 0.8f);
			timer = actualtime;
		}
		
		
	}
	
	void FireWeapon(){
            
		Rigidbody bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEnd.forward * 7500);
		
	}
	
	private Transform FindChild(string name){
		Transform[] trans = GetComponentsInChildren<Transform>();
		
		foreach(Transform t in trans){
			if(t.gameObject.name.Equals(name))
				return t;
		}		
		return null;
	}
}
