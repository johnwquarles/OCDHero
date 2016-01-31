using UnityEngine;
using System.Collections;

public class Sleeve : MonoBehaviour {
	public GameObject explosion;
	private Rigidbody rb;
	new private Transform transform;
	private float speed;
	private SceneScript script;

	void Start () {
		transform = GetComponent<Transform> ();
		script = GameObject.Find ("SceneScript").GetComponent<SceneScript> ();
		speed = script.speed;
	}

	void Update () {
		float newX = transform.position.x;
		newX += speed * Time.deltaTime;
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}

	void OnCollisionEnter (Collision other) {
		this.speed += 950;
		other.gameObject.GetComponent<EvilHand>().Stop();
		transform.Find ("Hand").GetComponent<Hand> ().destroy ();
		script.evilMsg.text = "WHAT??";
		script.nervousMsg.text = "get that outta here tho lol";
	}

	public void blowUp () {
		Instantiate(explosion, new Vector3 (transform.position.x + 170, transform.position.y, transform.position.z + 145), Quaternion.identity);
		Destroy (this.gameObject);
		script.explosionSound ();
	}
		
}
