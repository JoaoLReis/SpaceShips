using UnityEngine;
using System.Collections;

public class CursorChange : MonoBehaviour {
	
     
    void Start() {
    	Screen.showCursor = false;
    }
     
    void OnGUI() {
		
    	Vector3  mousePos = Input.mousePosition;
		transform.position = new Vector3(mousePos.x/Screen.width, mousePos.y/Screen.height, 0);
    }
}
