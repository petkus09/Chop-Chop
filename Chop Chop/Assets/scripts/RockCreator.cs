using UnityEngine;
using System.Collections;

public class RockCreator : MonoBehaviour {
	public GameObject rock;

	void Start () {
		StartCoroutine(Wait());
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds(3);
		var a = Random.Range (3, 6);
		for (int i = 0; i < a; i++) {
			Vector3 pos = transform.position;
			pos.z += Random.Range (-10, 10);

			var b = Instantiate (rock, pos, transform.rotation);
		}
	}
}
