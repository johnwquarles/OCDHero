using UnityEngine;
using System.Collections;

public class Pres_Butan_H : MonoBehaviour {
	// Use this for initialization
	float maximum_y_position;
	float minimum_y_position;
	int moving;

	void Start () {
	
		maximum_y_position = this.transform.position.y;
		minimum_y_position = this.transform.position.y - 0.1f;
		moving = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && moving == 0) {
			moving = -1;
		}

		if (this.transform.position.y <= minimum_y_position) {
			moving = 1;
			if (clock_updater_a.hours == 11) {
				if (clock_updater_a.ampm == "AM") {
					clock_updater_a.ampm = "PM";
				} else {
					clock_updater_a.ampm = "AM";
				}
			}

			if (clock_updater_a.hours == 12) {
				clock_updater_a.hours = 1;
			} else {
				clock_updater_a.hours += 1;
			}

		} else if (this.transform.position.y >= this.maximum_y_position && moving != -1) {
			moving = 0;
		}

		if (moving > 0) {
			float new_y = this.transform.position.y + 0.01f;
			this.transform.position = new Vector3 (transform.position.x, new_y, transform.position.z);
		} else if (moving < 0) {
			float new_y = this.transform.position.y - 0.01f;
			this.transform.position = new Vector3 (transform.position.x, new_y, transform.position.z);
		}
	}
}
