using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject flame;
	public GameObject turret;
	public GameObject bomb;
	public bool turretActivation = false;
	public bool bombActivation = false;
	private float speed = 5f;
	private float delay = 5f;
	private Vector2 direction;
	private PlayerController controller;
	public float SpeedPerFrame {
		get {
			return this.speed * Time.deltaTime;
		}
	}
	private Vector2 DetectKeyboardInput() {
		// Detects Player momvent
		Vector2 movementDirection = Vector2.zero;
		if (Input.GetKey(KeyCode.UpArrow)) {
			movementDirection += Vector2.up;
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			movementDirection += -1 * Vector2.up;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			movementDirection += -1 * Vector2.right;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			movementDirection += Vector2.right;
		}

		return movementDirection;
	}


	void Start() {
		controller = GetComponent<PlayerController>();
	}

	void Awake() {
		// De-activate all the powerups on start
		bomb.SetActive(false);
		flame.SetActive(false);
		turret.SetActive(false);
	}

	void Update() {
		this.direction = DetectKeyboardInput();
		Move(this.direction);

		if (turretActivation) {
			turret.SetActive(true);
			StartCoroutine(DeActivateTurret(this.delay));
		}
		if (bombActivation) {
			bomb.SetActive(true);
			StartCoroutine(DeActivateBomb(this.delay));
		}

		if (controller.moving.x != 0 || controller.moving.y !=0) {
			// Active flame animation whenever the player is moving
			flame.SetActive(true);
		}
		// Flame is off by default
		else {
			flame.SetActive(false);
		}
	}

	private void Move(Vector2 movementDierction) {
		this.gameObject.transform.localPosition += ((Vector3)movementDierction * this.SpeedPerFrame);
	}


	void OnTriggerEnter2D(Collider2D target) {
		// Destroy player once it touches an enemy
		if (target.gameObject.tag == "Enemy") {
			Destroy(this.gameObject);
		}
		// Turn on Powerup once its picked up
		if (target.gameObject.tag == "turretPowerUp") {
			turretActivation = true;
		}
		if (target.gameObject.tag == "bombPowerUp") {
			bombActivation = true;
		}
	}
	// De-Active powerups after 5 seconds
	private IEnumerator DeActivateTurret(float delay) {
		yield return new WaitForSeconds(delay);
		turret.SetActive(false);
		turretActivation = false;
	}

	private IEnumerator DeActivateBomb(float delay) {
		yield return new WaitForSeconds(delay); 
		bomb.SetActive(false);
		bombActivation= false;
	}
}
