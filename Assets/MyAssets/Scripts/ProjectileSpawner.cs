using UnityEngine;
using System.Collections;

public class ProjectileSpawner : MonoBehaviour {

	[SerializeField] private GameObject projectile = null;
	[SerializeField] private Transform projectileSpawnPoint = null;
	public float RateOfFire = 3;

	void Start() {
		StartCoroutine(ShootCoroutine(this.RateOfFire));
	}
	private IEnumerator ShootCoroutine (float delay) {
		while (true) {
			yield return new WaitForSeconds(delay);
			Shoot();
		}
	}
	public void Shoot() {
		GameObject projectile = Instantiate(this.projectile) as GameObject;
		projectile.transform.position = this.projectileSpawnPoint.transform.position;
		projectile.transform.rotation = this.projectileSpawnPoint.transform.rotation;
	}
}
