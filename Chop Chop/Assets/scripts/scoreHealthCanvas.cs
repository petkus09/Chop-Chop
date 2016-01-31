using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreHealthCanvas : MonoBehaviour {
	public Image health1;
	public Image health2;
	public Image health3;
	public float score = 0;
	public Text VisualScore;
	public GameObject controller;

	// Update is called once per frame
	void Update () {
		GameObject obj = GameObject.Find ("head");
		playerControll script = obj.GetComponent<playerControll> ();
		if (!script.dead) {
			score = obj.transform.position.x / 1f;
			VisualScore.text = 3+Mathf.RoundToInt (score) + "";
		}

		if(script.healthLeft == 2) {
			health3.gameObject.SetActive(false);
		}

		if(script.healthLeft == 1) {
			health2.gameObject.SetActive(false);
		}

		if(script.healthLeft < 1) {
			health1.gameObject.SetActive(false);
		}
	}
}
