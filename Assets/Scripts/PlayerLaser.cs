using UnityEngine;
using System.Collections;

public class PlayerLaser : BulletStats {

	// Use this for initialization
	void Start () {
	
		damage = 1;
		
	}
	
	
	public override void increaseDamage(){
		
		damage += 1;
	}
	
	public override void increaseArmorPen(){
		
		armorPen += 0.1f;
	}
}
