using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class Hands : MonoBehaviour {
	private float randomNum = 0;
	private float MIN_VALUE = -0.035f;
	private float MAX_VALUE = 0.035f;
	public float dirtTimer = 5.0f;
	public float timeRemaining;
	public Text timerText;
	public Text dirtText;

	void Start () {
		timeRemaining = 12 - (float)(GameState.state.levelCount / 8);
	}
	
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

		if (dirtTimer <= 0 && timeRemaining > 0) {
			SceneManager.LoadScene (1, LoadSceneMode.Single); 
		} else if (dirtTimer > 0 && timeRemaining <= 0) {
			SceneManager.LoadScene (2, LoadSceneMode.Single); 
		}

		// Update text
		timerText.text = "Time Remaining: " + Mathf.Round(timeRemaining).ToString();
		dirtText.text = "Dirt Meter: " + Mathf.Round (dirtTimer).ToString ();
	}

	void randomizeMovement(float randomNum) {
		Vector3 position = transform.position;
		float newPosition = position.x + randomNum;

		transform.position = new Vector3(newPosition, position.y, position.z);
	}

	void OnCollisionStay (Collision other) {
		dirtTimer -= Time.deltaTime;
	}
}