using UnityEngine;
using System.Collections;

public class clock_updater_b : MonoBehaviour {
	int update_count = 0;
	public static int seconds;
	public static int minutes;
	public static int hours;
	public static string ampm;

	int previous_seconds = -1;

	// Use this for initialization
	void Start () {
		update_count = 0;
		int difficulty = ((GameState.state.levelCount) / 4);
		int time_window = 20 - 2 * difficulty;
		if (time_window < 10) {
			time_window = 10;
		}
		seconds = 60 - time_window;
		minutes = 59;
		hours = 11;
		ampm = "AM";
		RenderClock ();
	}

	string RenderClock() {
		return PadNumber (hours) + ":" + PadNumber (minutes) + ":" + PadNumber (seconds) + " " + ampm;
	}

	string PadNumber (int number) {
		string a = number.ToString();
		if (a.Length < 2) 
		{
			a = "0" + a;
		}
		else if (a.Length > 2) 
		{
			a = a.Substring(a.Length-2, 2);
		}

		return(a);
	}

	// Update is called once per frame
	void Update () {
		update_count += 1;

		if (update_count % 60 == 0) {
			seconds += 1;

			if (seconds == 60) {
				seconds = 0;
				minutes += 1;

			}

			if (((hours == 12 && minutes == 0) || (hours == 11 && minutes == 60)) && ( seconds == 0 && previous_seconds == 59)) {
				if (ampm == "AM"){
					ampm = "PM";
				} else {
					ampm = "AM";
				}
			}
	
		}

		if (minutes == 60) {
			minutes = 0;
			hours += 1;
		}

		if (hours == 13) {
			hours = 1;

		}
		GetComponent<TextMesh> ().text = RenderClock ();
		previous_seconds = seconds;
	}

}