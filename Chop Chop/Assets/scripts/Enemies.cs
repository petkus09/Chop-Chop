﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Enemies : MonoBehaviour {
	public List<SingleEnemy> enemies;
	float objWidth = 1f;
	public GameObject head;
	int x = 0;
	int upFrontDist = 15;

	void Update () {



		x = (int)(head.transform.position.x / 1f);

		if (x % objWidth == 0) {
			for (int i = 0; i < enemies.Count; i++) {
				SingleEnemy se = enemies [i];

				if (Time.time > se.nextSpawnTime && ((x - se.lastXSpawn) > se.minDistBetweenEnemy)) {
					se.nextSpawnTime = Time.time + se.durationBetweenSpawns;
					se.lastXSpawn = x;

					Vector3 poss = new Vector3 ();
					poss.x = x + objWidth + upFrontDist + se.position.x;
					poss.y = -x - objWidth - upFrontDist + se.position.y;
					poss.z += se.position.z;
					if (se.randBetweenStairs)
						poss.z = Random.Range (-1, 1);
					
					var a = Instantiate (se.prefab, poss, Quaternion.Euler (se.rotation));
					Destroy (a, 15f);
				}
			}
		}
	}

	[System.Serializable]
	public class SingleEnemy {
		public GameObject prefab;
		public Vector3 position;
		public Vector3 rotation;
		public bool randBetweenStairs;

<<<<<<< HEAD
}
=======
		public float durationBetweenSpawns;
		public int minDistBetweenEnemy;

		[HideInInspector]
		public float nextSpawnTime;
		[HideInInspector]
		public int lastXSpawn;
	}
>>>>>>> a3fbe8514778a76c4964a1b56b3b3f4596334be2
}
