using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	[SerializeField] private float speed = 10f;
	[SerializeField] private float lifespan = 5f;
	[SerializeField] private Vector3 myDirection = Vector3.right;
	
	private bool isDestroyed = false;
	
	void Awake ()
	{
		StartCoroutine(LifespanCoroutine());
		StartCoroutine(MovementCoroutine());
	}
	
	void LateUpdate ()
	{
		if (this.isDestroyed)
		{
			Destroy(this.gameObject);
		}
	}
	
	private IEnumerator LifespanCoroutine ()
	{
		yield return new WaitForSeconds(this.lifespan);
		Destroy(this.gameObject);
	}
	
	private IEnumerator MovementCoroutine ()
	{
		while (true)
		{
			// Move the projectile in the set direction, at the set speed, smoothly through time, for each frame.
			this.transform.Translate(this.myDirection * this.speed * Time.deltaTime);
			yield return new WaitForEndOfFrame();
		}
	}
	
	void OnTriggerEnter2D (Collider2D target)
	{
		// When the projectile hits an Enemy it is destroyed
		if (target.gameObject.tag == "Enemy") {
			this.isDestroyed = true;
			Destroy(target.gameObject);
		}
	}
}
