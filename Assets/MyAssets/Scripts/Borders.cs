using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {


	// Destroys enemies once they touch this object
	void OnTriggerEnter2D (Collider2D target) {
		if (target.gameObject.tag == "Enemy") {
			Destroy(target.gameObject);
		}
	}
}
