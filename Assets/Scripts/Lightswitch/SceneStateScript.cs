using UnityEngine;
using System.Collections;

public class SceneStateScript : MonoBehaviour {
	public static int flicksToDo;
	public static int flicksDone;
	public static int timer;
	public static int currentLevel;
	public static int maxTimer;

	// Use this for initialization
	void Start () {
//		currentLevel = GameState.state.levelCount % 4;
		flicksToDo = Random.Range (7 + (currentLevel * 2), 12 + (currentLevel * 2));
		flicksToDo = 5;
		flicksDone = 0;
		maxTimer = 300;
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
			Debug.Log("fail");
		} else if (flicksDone == flicksToDo) {
			Debug.Log("pass");
		}
	}
}
