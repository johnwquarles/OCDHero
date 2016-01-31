using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
	public GameObject explosion;
	private AudioSource sound;
	private int randomNum;

	// Use this for initialization
	void Start () {
		GameState.state.levelCount = 0;
		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			SceneManager.LoadScene (1);
		} 
		randomNum = Random.Range (0, 180);
		if (randomNum > 176) {
			Instantiate(explosion, new Vector3 (898 + Random.Range(-5, 5), 150+ Random.Range(-30, 30), -31), Quaternion.identity);
			sound.pitch = Random.Range (0.7f, 1.6f);
			sound.Play();
		}
//		else if (Input.GetButtonDown ("Fire2")) {
//			Instantiate(explosion, new Vector3 (898 + Random.Range(-5, 5), 150+ Random.Range(-30, 30), -31), Quaternion.identity);
//			sound.pitch = Random.Range (0.7f, 1.6f);
//			sound.Play();
//		}
	}
}