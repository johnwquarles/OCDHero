﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneStateScript : MonoBehaviour {
	public static int flicksToDo;
	public static int flicksDone;
	public static int timer;
	public static int currentLevel;
	public static int maxTimer;

	// Use this for initialization
	void Awake () {
		currentLevel = GameState.state.levelCount % 4;
		flicksToDo = Random.Range (7 + (currentLevel * 2), 12 + (currentLevel * 2));
//		flicksToDo = 5;
		flicksDone = 0;
		maxTimer = 300;
		timer = 0;
	}
		
	void OnGUI () {
		GUI.skin.label.fontSize = 22;
		GUI.Label (new Rect (100, 100, 100, 100), "Done: " + flicksDone.ToString());
		GUI.Label (new Rect (100, 200, 100, 100), "To Do: " + flicksToDo.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		if ((timer > maxTimer && flicksDone < flicksToDo) || flicksDone > flicksToDo) {
			SceneManager.LoadScene (2, LoadSceneMode.Single);
		} else if (timer > maxTimer && flicksDone == flicksToDo) {
			SceneManager.LoadScene (1, LoadSceneMode.Single);
		}
	}
}
