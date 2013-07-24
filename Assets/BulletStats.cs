using UnityEngine;
using System.Collections;

public class BulletStats : MonoBehaviour {
	
	private float damage = 1f;
	private float armorPen = 0f;
	
	public void increaseDamage(){
		damage += 1f;
	}
	
	public void increaseArmorPen(){
		armorPen += 0.1f;
	}
	public float getDamage(){
		return damage;
	}
	
	public float getArmorPen(){
		return armorPen;
	}
}
