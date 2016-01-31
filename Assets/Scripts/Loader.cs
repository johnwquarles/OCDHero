using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {
	private int nextSceneIndex;
	private int lastLevelIndex;
	private int levelsInGameCount;

	void Start () {
		GameState.state.levelCount++;
		lastLevelIndex = GameState.state.lastLevelIndex;
		levelsInGameCount = SceneManager.sceneCountInBuildSettings;

		nextSceneIndex = randomLevel();
		while (nextSceneIndex == lastLevelIndex) {
			nextSceneIndex = randomLevel ();
		}

		GameState.state.lastLevelIndex = nextSceneIndex;
		SceneManager.LoadScene (nextSceneIndex, LoadSceneMode.Single);
	}

	int randomLevel () {
		return Random.Range (3, levelsInGameCount);
	}
}
