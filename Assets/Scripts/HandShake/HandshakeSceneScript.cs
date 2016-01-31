using UnityEngine;
using System.Collections;
using System;

public class HandshakeSceneScript : MonoBehaviour {
	public float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1f / 60f;
	}
}
