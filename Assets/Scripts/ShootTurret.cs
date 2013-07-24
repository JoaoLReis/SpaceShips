using UnityEngine;
using System.Collections;

public class ShootTurret : MonoBehaviour {
	
	
	public Rigidbody bulletPrefab;
    public Transform barrelEndLeft;
    public Transform barrelEndRight;
	public float attackspeed = 0.50f;
	public float timer = 0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//bool downFkey = Input.GetButtonDown("Fire1");
       // bool heldFkey = Input.GetButton("Fire1");
        //bool upFkey = Input.GetKeyUp(KeyCode.F);
		float actualtime = Time.time;
		//Debug.Log(actualtime);
		//if(downFkey || heldFkey){
		if(actualtime > timer + attackspeed){
			FireWeapon();
			timer = actualtime;
		}
		//}
		
		
	}
	
	void FireWeapon(){
            
		Rigidbody bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, barrelEndLeft.position, barrelEndLeft.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndLeft.up * 5000);
		bulletInstance = Instantiate(bulletPrefab, barrelEndRight.position, barrelEndRight.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndRight.up * 5000);
		
		
	}
}
