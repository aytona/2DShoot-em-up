using UnityEngine;
using System.Collections;

public class EnemyBSpawnerMovement : MonoBehaviour {

	public int direction = 1;

	// Moves spawner left to right
	void Update() {
		transform.position = new Vector3(Mathf.PingPong(Time.time, 20) * direction, transform.position.y, transform.position.z);

	}
}
