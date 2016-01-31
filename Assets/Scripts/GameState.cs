using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	public static GameState state;

	public int levelCount;
	public int lastLevelIndex;

	void Awake () {
		lastLevelIndex = 9999;
		if (state == null) {
			DontDestroyOnLoad (gameObject);
			state = this;
		} else if (state != this) {
			Destroy (gameObject);
		}
	}
}
