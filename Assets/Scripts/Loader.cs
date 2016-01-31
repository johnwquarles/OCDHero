using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {
	private int nextSceneIndex;

	void Start () {
		GameState.state.levelCount++;
		// Random.Range is inclusive on min, exclusive on max FOR INTEGERS. Both inclusive on float.
		// first two scenes are title screen & loader; choose from scenes available other than these.
		nextSceneIndex = Random.Range (3, SceneManager.sceneCountInBuildSettings);
		SceneManager.LoadScene (nextSceneIndex, LoadSceneMode.Single);
	}
}
