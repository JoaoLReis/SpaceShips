using UnityEngine;
using System.Collections;

public class ShootBasicShipTurret : MonoBehaviour {

	private Rigidbody bulletPrefab;
    private Transform barrelEndLeft;
    private Transform barrelEndRight;
	public float attackspeed = 3.5f;
	public float timer = 0f;
	
	void Start(){
		GameObject bullet;
		barrelEndLeft = FindChild("BarrelEndLeft");
		barrelEndRight = FindChild("BarrelEndRight");
		bullet = (GameObject) Resources.Load("BasicEnemyLaser");
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
        bulletInstance.AddForce(barrelEndLeft.forward * 7500);
		bulletInstance = Instantiate(bulletPrefab, barrelEndRight.position, barrelEndRight.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndRight.forward * 7500);
		
		
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
