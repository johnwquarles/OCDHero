using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Governor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (clock_updater_a.hours == clock_updater_b.hours && clock_updater_b.minutes == clock_updater_a.minutes && clock_updater_b.seconds == clock_updater_a.seconds && clock_updater_a.ampm == clock_updater_b.ampm) {
			SceneManager.LoadScene (1, LoadSceneMode.Single);		
		} else if (clock_updater_b.minutes == 0 && clock_updater_b.seconds == 2) {
			SceneManager.LoadScene (2, LoadSceneMode.Single);
		}
	}
}
