using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	// Destroys enemies whenever the bomb collides with them
	void OnCollisionEnter2D (Collision2D target) {
		if (target.gameObject.tag == "Enemy") {
			Destroy(target.gameObject);
		}
	}
}
