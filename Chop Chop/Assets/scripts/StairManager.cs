using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StairManager : MonoBehaviour {
	public GameObject stair;
	List<GameObject> stairs;
	//int step = 0;
	//int maxStepCount = 12;
	float objWidth = 6f;
	int x = 0;
	int itemCount = 5;
	public GameObject head;
	void Start () {
		stairs = new List<GameObject> ();
		for (int i = -itemCount; i < itemCount; i++) {
			var a = (GameObject)Instantiate (stair, new Vector3 (objWidth * i, -objWidth * i, 0), Quaternion.Euler (new Vector3 (0, 90, 0)));
			stairs.Add (a);
		}
		//head = (GameObject)Instantiate (head, new Vector3 (0, 1, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void Update () {
		x = (int)(head.transform.position.x / 1f);
		if (x > 5) {
			//step++;
			/*foreach (GameObject stair in stairs) {
				Vector3 pos = stair.transform.position;
				pos.x = objWidth * x;
				pos.y = -objWidth * x;
				stair.transform.position = pos;
			}*/
			//if (step == maxStepCount) {

			if (x % objWidth == 0) {
				for (int i = -itemCount; i < itemCount; i++) {
					stairs [i + itemCount].transform.position = new Vector3 (x + objWidth * i, -x - objWidth * i, 0);
				}
			}

				//topStair.transform.position = new Vector3 (5, -5, 0);
				//stairs.Insert (9, topStair);
				//step = 0;
			//}
		}
	}

	void LateUpdate() {

	}
}
