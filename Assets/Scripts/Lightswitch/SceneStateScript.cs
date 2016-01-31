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
		GUI.skin.label.fontSize = 22;
		GUI.Label (new Rect (100, 100, 100, 100), "Done: " + flicksDone.ToString());
		GUI.Label (new Rect (100, 200, 100, 100), "To Do: " + flicksToDo.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
	}
}
