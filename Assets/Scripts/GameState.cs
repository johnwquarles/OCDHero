using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	public static GameState state;

	public int levelCount;

	void Awake () {
		DontDestroyOnLoad (gameObject);
		state = this;
	}
}
