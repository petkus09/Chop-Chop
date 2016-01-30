using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreHealthCanvas : MonoBehaviour {


	public int healthLeft = 3;
	public Image health1;
	public Image health2;
	public Image health3;
	public float score = 0;
	public Text VisualScore;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
			
		score += 10 * Time.deltaTime;
		VisualScore.text = Mathf.RoundToInt(score) + "";
		if(healthLeft == 2) {
			health3.gameObject.SetActive(false);
		}
		if(healthLeft == 1) {
			health2.gameObject.SetActive(false);
		}
		if(healthLeft == 0) {
			health1.gameObject.SetActive(false);
		}
	}
}
