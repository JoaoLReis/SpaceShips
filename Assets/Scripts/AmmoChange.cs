using UnityEngine;
using System.Collections;

public class AmmoChange : MonoBehaviour {
	
	private int ammo;
	// Use this for initialization
	void Start () {
		//TODO update
		ammo = 10;
		guiText.text = "AmmoChange: " + ammo;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void changeAmmo(int ammo){
		
		
	}
	
}
