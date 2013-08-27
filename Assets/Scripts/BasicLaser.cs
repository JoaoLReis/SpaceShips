using UnityEngine;
using System.Collections;

public class BasicLaser : BulletStats {

	// Use this for initialization
	void Start () {
	
		damage = 1;
		
	}
	
	public override void increaseDamage(){
		
		damage += 0.5f;
	}
	
	public override void increaseArmorPen(){
		
		armorPen += 0.1f;
	}
}
