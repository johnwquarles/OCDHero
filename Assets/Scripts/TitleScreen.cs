﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameState.state.levelCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			SceneManager.LoadScene(1);
		}	
	}
}
