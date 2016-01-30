using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	public GameObject enemy;
	int step = 0;
	int maxStepCount = 40;
	float objWidth = 1f;
	void Start () {
		enemy = (GameObject)Instantiate (enemy, new Vector3 (0, 1, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void Update () {
		Vector3 pos = enemy.transform.position;
		pos.x -= objWidth / maxStepCount;
		pos.y += objWidth / maxStepCount;
		enemy.transform.position = pos;
	}
}
