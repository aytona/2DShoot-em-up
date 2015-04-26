using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Vector2 moving = new Vector2();

	// Update is called once per frame
	void Update () {
		// Checks to see if the player is moving
		moving.x = moving.y = 0;
		
		if(Input.GetKey(KeyCode.RightArrow)) {
			moving.x = 1;
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {
			moving.x = 1;
		}
		if(Input.GetKey(KeyCode.UpArrow)) {
			moving.y = 1;
		}
		if(Input.GetKey(KeyCode.DownArrow)) {
			moving.y = -1;
		}
	}
}
