using UnityEngine;
using System.Collections;

public class SimpleBullet : BulletStats {

	// Use this for initialization
	void Start () {
	
		damage = 0.5f;
		
	}
	
	public override void increaseDamage(){
		
		damage += 0.5f;		
	}
	
	public override void increaseArmorPen(){
		
		armorPen += 0.05f;
	}
}
