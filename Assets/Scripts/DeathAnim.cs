using UnityEngine;
using System.Collections;

public class DeathAnim : MonoBehaviour {
	
	private int x = 0;
	public void anim(){
		
		x = 1;
		Invoke("playps", 2);
		Destroy(GetComponentInChildren<Light>(), 2);
		
		GetComponentInChildren<Light>().intensity = Mathf.Lerp(GetComponentInChildren<Light>().intensity, 8, Time.deltaTime);
	}
	
	void playps(){
		
		x = 0;
		GetComponentInChildren<ParticleSystem>().Play();
		
	}
	
	void Update(){
		
		if(x==1)
			GetComponentInChildren<Light>().intensity = Mathf.Lerp(GetComponentInChildren<Light>().intensity, 8, Time.deltaTime);
	}
}
