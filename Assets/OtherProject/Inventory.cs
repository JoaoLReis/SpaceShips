using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	public int numBullets = 50;
	public int healtBar = 100;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void increaseAmmo(){
		numBullets += 10;
	}
	
	public void changeAmmoAmount(int ammo){
		numBullets += ammo;	
		
	}
	
}
