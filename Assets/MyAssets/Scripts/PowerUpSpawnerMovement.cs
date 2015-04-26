using UnityEngine;
using System.Collections;

public class PowerUpSpawnerMovement : MonoBehaviour {

	[SerializeField] Transform spawner;

	// Moves spawner in random Y coordinates from -10 to 10
	void Update() {
		transform.position = new Vector3(30 ,Random.Range (-10,10), 0);
	}
}
