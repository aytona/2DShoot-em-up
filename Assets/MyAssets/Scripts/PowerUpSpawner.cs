using UnityEngine;
using System.Collections;

public class PowerUpSpawner : MonoBehaviour {

	[SerializeField] private GameObject bomb = null;
	[SerializeField] private GameObject turret = null;
	[SerializeField] private Transform projectileSpawnPoint = null;
	public float RateOfFire = 10f;
	private int random;
	
	void Start() {
		StartCoroutine(ShootCoroutine(this.RateOfFire));
	}

	void Update() {
		// random number generator
		random = Random.Range(1,100);
	}
	private IEnumerator ShootCoroutine (float delay) {
		while (true) {
			yield return new WaitForSeconds(delay);
			Shoot();
		}
	}
	// Once the number is chosen, this snippet will decide which powerup to spawn
	public void Shoot() {
		if (random <= 50) {
			GameObject projectile = Instantiate(this.bomb) as GameObject;
			projectile.transform.position = this.projectileSpawnPoint.transform.position;
			projectile.transform.rotation = this.projectileSpawnPoint.transform.rotation;
		}
		if (random >= 51) {
			GameObject projectile = Instantiate(this.turret) as GameObject;
			projectile.transform.position = this.projectileSpawnPoint.transform.position;
			projectile.transform.rotation = this.projectileSpawnPoint.transform.rotation;
		}
	}
}
