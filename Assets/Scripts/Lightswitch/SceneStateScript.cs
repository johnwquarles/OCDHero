using UnityEngine;
using System.Collections;

public class SceneStateScript : MonoBehaviour {
	public static int flicksToDo;
	public static int flicksDone;
	public static int timer;

	// Use this for initialization
	void Start () {
		flicksToDo = Random.Range (7, 12);
		flicksDone = 0;

	}
		
	void OnGUI () {
		GUI.Label (new Rect (100, 100, 100, 20), "Done: " + flicksDone.ToString());
		GUI.Label (new Rect (100, 120, 100, 20), "To Do: " + flicksToDo.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
	}
}
