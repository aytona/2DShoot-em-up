using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	// Destroys this object once they enter a Wall
	void OnTriggerEnter2D (Collider2D target) {
		if (target.gameObject.tag == "Wall") {
			Destroy(this.gameObject);
		}
	}
}
