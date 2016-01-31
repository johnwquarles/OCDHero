using UnityEngine;
using System.Collections;

public class EvilHand : MonoBehaviour {
	private Rigidbody rb;
	new private Transform transform;
	private bool stopped;
	private float speed;
	private SceneScript script;

	void Start () {
		transform = GetComponent<Transform> ();
		stopped = false;
		script = GameObject.Find ("SceneScript").GetComponent<SceneScript> ();
		speed = script.speed;
	}

	void Update () {
		if (!stopped) {
			float newX = transform.position.x;
			newX += -1 * speed * Time.deltaTime;
			transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		}
	}

	public void Stop () {
		stopped = true;
	}
}
