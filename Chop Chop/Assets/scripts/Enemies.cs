using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	public GameObject enemy;
	int step = 0;
	int maxStepCount = 2;
	float objWidth = 1f;
	void Start () {
		enemy = (GameObject)Instantiate (enemy, new Vector3 (16, -14, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void Update () {
		step++;
		Vector3 pos = enemy.transform.position;
		pos.x -= objWidth / maxStepCount;
		pos.y += objWidth / maxStepCount;
		enemy.transform.position = pos;
		if (step == maxStepCount * 28) {
			Vector3 poss = enemy.transform.position;
			poss.x = 16;
			poss.y = -14;
			poss.z = Random.Range (-5, 5);
			enemy.transform.position = poss;
			step = 0;
		}
	}
}
