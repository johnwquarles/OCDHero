using UnityEngine;
using System.Collections;

public class EvilHand : MonoBehaviour {
	private Rigidbody rb;
	new private Transform transform;
	private bool stopped;

	void Start () {
		transform = GetComponent<Transform> ();
		stopped = false;
	}

	void Update () {
		if (!stopped) {
			float newX = transform.position.x;
			newX += -100 * Time.deltaTime;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}
	}

	public void Stop () {
		stopped = true;
	}
}
