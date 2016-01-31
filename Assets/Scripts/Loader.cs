using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {
	private Scene[] scenes;
	private int nextSceneIndex;

	// Use this for initialization
	void Start () {
		GameState.state.levelCount++;
		scenes = SceneManager.GetAllScenes ();
		// Random.Range is inclusive on min, exclusive on max FOR INTEGERS. Both inclusive on float.
		// first two scenes are title screen & loader; choose from scenes available other than these.
		nextSceneIndex = Random.Range (2, scenes.Length);
		SceneManager.LoadScene (nextSceneIndex, LoadSceneMode.Single);
	}
}
