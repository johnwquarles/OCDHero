using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

	void OnCollisionEnter (Collision other) {
		Destroy (other.gameObject);
		gameObject.transform.parent.gameObject.GetComponent<Sleeve> ().blowUp ();
	}
}
