using UnityEngine;
using System.Collections;

public class EnemySpawnerMovement : MonoBehaviour {

	public int direction = 1;

	// Moves spawner up and down
	void Update() {
		transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 10) * direction, transform.position.z);
	}
}
