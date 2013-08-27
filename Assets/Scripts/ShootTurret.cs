using UnityEngine;
using System.Collections;

public class ShootTurret : MonoBehaviour {
	
	
	private Rigidbody bulletPrefab;
    private Transform barrelEndLeft;
    private Transform barrelEndRight;
	public float attackspeed = 1.25f;
	public float timer = 0f;
	
	void Start(){
		GameObject bullet;
		barrelEndLeft = FindChild("BarrelEndLeft");
		barrelEndRight = FindChild("BarrelEndRight");
		bullet = (GameObject) Resources.Load("Laser");
		bulletPrefab = bullet.GetComponent<Rigidbody>();
	}
	
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
	
	private Transform FindChild(string name){
		Transform[] trans = GetComponentsInChildren<Transform>();
		
		foreach(Transform t in trans){
			if(t.gameObject.name.Equals(name))
				return t;
		}		
		return null;
	}
}
