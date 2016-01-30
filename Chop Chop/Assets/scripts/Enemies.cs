using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	public GameObject enemy;
	int step = 0;
	int maxStepCount = 20;
	float objWidth = 1f;
	void Start () {
		enemy = (GameObject)Instantiate (enemy, new Vector3 (6, -4, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void Update () {
		step++;
		Vector3 pos = enemy.transform.position;
		pos.x -= objWidth / maxStepCount;
		pos.y += objWidth / maxStepCount;
		enemy.transform.position = pos;
		if (step == maxStepCount * 5) {
			Vector3 poss = enemy.transform.position;
			poss.x = 6;
			poss.y = -4;
			enemy.transform.position = poss;
			step = 0;
		}
	}
}
