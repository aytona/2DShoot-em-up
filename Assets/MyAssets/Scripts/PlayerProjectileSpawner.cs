using UnityEngine;
using System.Collections;

public class PlayerProjectileSpawner : MonoBehaviour {

	[SerializeField] private GameObject projectile = null;
	[SerializeField] private Transform projectileSpawn = null;
	
	// Update is called once per frame
	void Update () {
		// Fires projectile whenever Space is pressed
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject projectile = Instantiate(this.projectile) as GameObject;

			projectile.transform.eulerAngles = this.projectileSpawn.eulerAngles;
			projectile.transform.position = this.projectileSpawn.position;
		}
	}
}
