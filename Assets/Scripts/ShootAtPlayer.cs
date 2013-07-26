using UnityEngine;
using System.Collections;

public class ShootAtPlayer : MonoBehaviour {
	
	
	public Rigidbody bulletPrefab;
    public Transform barrelEndLeft;
    public Transform barrelEndRight;
	public float attackspeed = 0.50f;
	public float timer = 0f;
	private Quaternion turretrotationleft;
	public GameObject player;
	private Transform playerlocal;
	
	// Use this for initialization
	void Start () {
		
		playerlocal = player.GetComponent<Transform>();
		barrelEndLeft.LookAt(playerlocal);
		barrelEndRight.LookAt(playerlocal);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		playerlocal = player.GetComponent<Transform>();
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
        barrelEndLeft.LookAt(playerlocal);
		barrelEndRight.LookAt(playerlocal);
		barrelEndLeft.RotateAround (barrelEndLeft.position, Vector3.right, 90);  
		barrelEndRight.RotateAround (barrelEndRight.position, Vector3.right, 90);  
		barrelEndLeft.RotateAround (barrelEndLeft.position, Vector3.up, 180);  
		barrelEndRight.RotateAround (barrelEndRight.position, Vector3.up, 180);    
		
		Rigidbody bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, barrelEndLeft.position, barrelEndLeft.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndLeft.forward * 5000);
		bulletInstance = Instantiate(bulletPrefab, barrelEndRight.position, barrelEndRight.rotation) as Rigidbody;
        bulletInstance.AddForce(barrelEndRight.forward * 5000);
		
		
	}
}
