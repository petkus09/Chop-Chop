using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StairManager : MonoBehaviour {
	public GameObject stair;
	List<GameObject> stairs;
	//int step = 0;
	//int maxStepCount = 12;
	float objWidth = 40f;
	int x = 0;

	int itemCount = 7;
	int half;


	public GameObject head;
	void Start () {
		half = (int)(itemCount / 2) + itemCount % 2;

		stairs = new List<GameObject> ();
		for (int i = 0; i < itemCount; i++) {
			var a = (GameObject)Instantiate (stair, new Vector3 (objWidth * i, -objWidth * i, 0), Quaternion.Euler (new Vector3 (0, 90, 0)));
			stairs.Add (a);
		}
		//head = (GameObject)Instantiate (head, new Vector3 (0, 1, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void Update () {
		x = (int)(head.transform.position.x / 1f);
		if (x > 80) {
			//step++;
			/*foreach (GameObject stair in stairs) {
				Vector3 pos = stair.transform.position;
				pos.x = objWidth * x;
				pos.y = -objWidth * x;
				stair.transform.position = pos;
			}*/
			//if (step == maxStepCount) {

			if (x % objWidth == 0) {
				for (int i = half - itemCount; i < half; i++) {
					stairs [i + itemCount - half].transform.position = new Vector3 (x + objWidth * i, -x - objWidth * i, 0);
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
