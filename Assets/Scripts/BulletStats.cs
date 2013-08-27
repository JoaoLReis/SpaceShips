using UnityEngine;
using System.Collections;

public class BulletStats : MonoBehaviour {
	
	protected float damage = 0;
	protected float armorPen = 0;
	
	virtual public void increaseDamage(){}
	
	virtual public void increaseArmorPen(){}
	
	public float getDamage(){
		return damage;
	}
	
	public float getArmorPen(){
		return armorPen;
	}
}
