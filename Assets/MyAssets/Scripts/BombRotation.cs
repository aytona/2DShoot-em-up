using UnityEngine;
using System.Collections;

public class BombRotation : MonoBehaviour {

	public int speed = 10;

	void Update() {
		// Rotates the Z of the bomb holder
		transform.Rotate(0, 0, speed * Time.deltaTime);
	}
}
