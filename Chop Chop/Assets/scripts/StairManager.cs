using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StairManager : MonoBehaviour {
	public GameObject stair;
	List<GameObject> stairs;
	int step = 0;
	int maxStepCount = 12;
	float objWidth = 6f;

	//public GameObject head;
	void Start () {
		stairs = new List<GameObject> ();
		for (int i = -5; i < 5; i++) {
			var a = (GameObject)Instantiate (stair, new Vector3 (objWidth * i, -objWidth * i, 0), Quaternion.Euler (new Vector3 (0, 90, 0)));
			stairs.Add (a);
		}
		//head = (GameObject)Instantiate (head, new Vector3 (0, 1, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void Update () {
		step++;
		foreach (GameObject stair in stairs) {
			Vector3 pos = stair.transform.position;
			pos.x -= objWidth / maxStepCount;
			pos.y += objWidth / maxStepCount;
			stair.transform.position = pos;
		}
		if (step == maxStepCount) {
			var topStair = stairs [0];
			for (int i = -5; i < 5; i++) {
				stairs [i + 5].transform.position = new Vector3 (objWidth * i, -objWidth * i, 0);
			}
			//topStair.transform.position = new Vector3 (5, -5, 0);
			//stairs.Insert (9, topStair);

			//stairs.Remove(topStair);
			//DestroyImmediate (stair, true);
			//var a = (GameObject)Instantiate (stair, new Vector3 (5, -5, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
			//stairs.Add (a);
			step = 0;
		}
			
		/*Vector3 poss = head.transform.position;
		poss.x = 0;
		poss.y = 1f + 1f / ((maxStepCount / 2) - (step - (maxStepCount / 2)));
		poss.z = 0;
		head.transform.position = poss;*/
	}
}
