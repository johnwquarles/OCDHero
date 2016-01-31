using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {
	new private Transform transform;
	private int speed;

	void Start () {
		transform = GetComponent<Transform> ();
		speed = 1000;
	}

	void OnCollisionEnter (Collision other) {
		Destroy (other.gameObject);
		gameObject.transform.parent.gameObject.GetComponent<Sleeve> ().blowUp ();
	}

	void Update () {
		if (Input.GetButtonUp ("Fire1")) {
			float newX = transform.position.x;
			newX -= speed * Time.deltaTime;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}
	}

	public void destroy () {
		Destroy (this.gameObject);
	}
}
