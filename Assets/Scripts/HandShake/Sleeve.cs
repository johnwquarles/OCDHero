using UnityEngine;
using System.Collections;

public class Sleeve : MonoBehaviour {
	public GameObject explosion;
	private Rigidbody rb;
	new private Transform transform;
	private float speed;
	private SceneScript script;
	private string[] evilMsgs;
	private string[] nervousMsgs;

	void Start () {
		transform = GetComponent<Transform> ();
		script = GameObject.Find ("SceneScript").GetComponent<SceneScript> ();
		speed = script.speed;
		evilMsgs = new string[]{ "WHAT??", "wat", "OMFG", "THAT BUT WHAT"};
		nervousMsgs = new string[]{ "get that outta here tho lol", "no shakes thx", "nah I'm good", "maybe later lol"};
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
		script.evilMsg.text = evilMsgs[Random.Range(0, evilMsgs.Length)];
		script.nervousMsg.text = nervousMsgs[Random.Range(0, nervousMsgs.Length)];
	}

	public void blowUp () {
		Instantiate(explosion, new Vector3 (transform.position.x + 170, transform.position.y, transform.position.z + 145), Quaternion.identity);
		Destroy (this.gameObject);
		script.explosionSound ();
	}
}
