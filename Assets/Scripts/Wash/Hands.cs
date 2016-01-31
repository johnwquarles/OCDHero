using UnityEngine;
using System.Collections;

public class Hands : MonoBehaviour {
	private float randomNum = 0;
	private float MIN_VALUE = -0.035f;
	private float MAX_VALUE = 0.035f;
	public int dirtMeter = 5;
	public float timeRemaining = 12;

	void Start () {}
	
	// Update is called once per frame
	void Update () {
		// Reference to old position
		Vector3 position = transform.position;
		if (Input.GetKey (KeyCode.A)) {
			float newX = position.x - 0.05f;
			transform.position = new Vector3(newX, position.y, position.z);
		}

		if (Input.GetKey (KeyCode.D)) {
			float newX = position.x + 0.05f;
			transform.position = new Vector3(newX, position.y, position.z);	
		}


		// Randomize Movement
		if (Time.frameCount % 24 == 0) {
			randomNum = Random.Range(MIN_VALUE, MAX_VALUE);
		} 
		
		randomizeMovement(randomNum);

		timeRemaining -= Time.deltaTime;
		Debug.Log(timeRemaining);

	}

	void randomizeMovement(float randomNum) {
		Vector3 position = transform.position;
		float newPosition = position.x + randomNum;

		transform.position = new Vector3(newPosition, position.y, position.z);
	}

	void OnCollisionStay (Collision other) {
		
	}
}