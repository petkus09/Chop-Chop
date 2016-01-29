using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StairManager : MonoBehaviour {
	public GameObject stair;
	List<GameObject> stairs;
	int step = 0;
	int maxStepCount = 50;
	void Start () {
		stairs = new List<GameObject> ();
		for (int i = -5; i < 5; i++) {
			var a = (GameObject)Instantiate (stair, new Vector3 (i, -1 * i, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
			if (i == -5)
				a.tag = "tag0";
			stairs.Add (a);
		}
	}

	void Update () {
		step++;
		foreach (GameObject stair in stairs) {
			Vector3 pos = stair.transform.position;
			pos.x -= 1f / maxStepCount;
			pos.y += 1f / maxStepCount;
			stair.transform.position = pos;
		}
		if (step == maxStepCount - 1) {
			var topStair = stairs [0];
			for (int i = -5; i < 5; i++) {
				stairs [i + 5].transform.position = new Vector3 (i, -1 * i, 0);
			}
			//topStair.transform.position = new Vector3 (5, -5, 0);
			//stairs.Insert (9, topStair);

			//stairs.Remove(topStair);
			//DestroyImmediate (stair, true);
			//var a = (GameObject)Instantiate (stair, new Vector3 (5, -5, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
			//stairs.Add (a);
			step = 0;
		}
	}
}
