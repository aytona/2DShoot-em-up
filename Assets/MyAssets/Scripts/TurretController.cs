using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour {

	public int speed = 50;
	
	// Update is called once per frame
	void Update () {
		// Whenever A or W is pressed
		// Turret will rotate clockwise
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W)) {
			transform.Rotate(0, 0, speed * Time.deltaTime);
		}
		// Whenever D or S is pressed
		// Turret will rotate counter-clockwise
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)) {
			transform.Rotate(0, 0, -speed* Time.deltaTime);
		}
	}
}
