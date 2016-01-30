using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Enemies : MonoBehaviour {
	public List<SingleEnemy> enemies;
	public GameObject enemy;
	float objWidth = 1f;
	public GameObject head;
	int x = 0;
	int upFrontDist = 15;

	float nextSpawnTime;
	public float durationBetweenSpawns = 2f;
	int lastXSpawn = 0;
	int minDistBetweenEnemy = 10;

	void Update () {
<<<<<<< HEAD

=======
>>>>>>> b40cb3ffd144db26f3f36358d9c3b55140a6319b
		x = (int)(head.transform.position.x / 1f);

		/*step++;
		Vector3 pos = enemy.transform.position;
		pos.x -= objWidth / maxStepCount;
		pos.y += objWidth / maxStepCount;
		enemy.transform.position = pos;
 
		if (step == maxStepCount * 30) {
			if (step == maxStepCount * 28) {

				Vector3 poss = enemy.transform.position;
				poss.x = 16;
				poss.y = -14;
				poss.z = Random.Range (-5, 5);
				enemy.transform.position = poss;
				step = 0;
			}
		}*/
		/*if (x % objWidth == 0) {
			if (Time.time > nextSpawnTime && ((x - lastXSpawn) > minDistBetweenEnemy)) {
				nextSpawnTime = Time.time + durationBetweenSpawns;
				lastXSpawn = x;

				Vector3 poss = new Vector3 ();
				poss.x = x + objWidth + upFrontDist;
				//poss.y = -x - objWidth - upFrontDist + 3;
				poss.y = -x - objWidth - upFrontDist + 5;
				//poss.z = Random.Range (-5, 5);
				poss.z = 10;
				var a = Instantiate (enemy, poss, Quaternion.Euler (new Vector3 (270, 270, 0)));
				Destroy (a, 15f);
			}
		}*/

		if (x % objWidth == 0) {
			if (Time.time > nextSpawnTime && ((x - lastXSpawn) > minDistBetweenEnemy)) {
				nextSpawnTime = Time.time + durationBetweenSpawns;
				lastXSpawn = x;

				foreach (SingleEnemy se in enemies) {
					Debug.Log ("a");
					Vector3 poss = new Vector3 ();
					poss.x = x + objWidth + upFrontDist + se.position.x;
					poss.y = -x - objWidth - upFrontDist + se.position.y;
					poss.z += se.position.z;
					if (se.randBetweenStairs)
						poss.z = Random.Range (-5, 5);
					
					var a = Instantiate (se.prefab, poss, Quaternion.Euler (se.rotation));
					Destroy (a, 15f);
				}
			}
		}
	}

	[System.Serializable]
	public struct SingleEnemy {
		public GameObject prefab;
		public Vector3 position;
		public Vector3 rotation;
		public bool randBetweenStairs;
<<<<<<< HEAD
}


=======
	}
>>>>>>> b40cb3ffd144db26f3f36358d9c3b55140a6319b
}
