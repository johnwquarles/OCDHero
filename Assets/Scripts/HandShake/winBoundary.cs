using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class winBoundary : MonoBehaviour {

	void OnCollisionEnter (Collision other) {
		SceneManager.LoadScene (1);
	}
}
