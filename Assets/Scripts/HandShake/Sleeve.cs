using UnityEngine;
using System.Collections;

public class Sleeve : MonoBehaviour {
	private Rigidbody rb;
	new private Transform transform;
	private int speed;

	void Start () {
		transform = GetComponent<Transform> ();
		speed = 100 * GameState.state.levelCount;
	}

	void Update () {
		float newX = transform.position.x;
		newX += speed * Time.deltaTime;
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}

	void OnCollisionEnter (Collision other) {
		this.speed += 700;
		other.gameObject.GetComponent<EvilHand>().Stop();
	}

	public void blowUp () {
		Destroy (this.gameObject);
	}
		
}
