using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

	public GameObject health;
	public GameObject mainMenu;
	public GameObject deathMenu;
	public Text HighScore;
	public Text CurrentScore;
	public Text bumps;
	public int distance = 0;



	// Use this for initialization
	void Start () {
		//Time.timeScale = 0;
	}
	void Update() {
		GameObject obj = GameObject.Find ("head");
		playerControll script = obj.GetComponent<playerControll> ();
		if (script.dead) {
			deathMenu.SetActive (true);
			health.SetActive (false);
			CurrentScore.text = 3+ Mathf.RoundToInt (distance) + "";

			if (PlayerPrefs.HasKey ("record")) {
				int maxScore = PlayerPrefs.GetInt ("record");
				if (distance > maxScore) {
					PlayerPrefs.SetInt ("record", distance);
				}	
				HighScore.text = 3+ Mathf.RoundToInt (maxScore) + "";
			} else {
				PlayerPrefs.SetInt ("record", 0);
				HighScore.text = 3+ Mathf.RoundToInt (0) + "";
			}

		}
		if (script.dead == false) {
			distance = (int)(obj.transform.position.x / 1f);
			bumps.text = script.bumpsCount.ToString();
		}

	
	}

	public void paly() {
		GameObject obj = GameObject.Find("head");
		SoundManager sound = obj.GetComponent<SoundManager> ();
		sound.button (transform.position);

		//Time.timeScale = 1;
		mainMenu.SetActive (false);
		//deathMenu.SetActive(true);
		GameObject ga = GameObject.FindGameObjectWithTag("killer");
		ga.GetComponent<Animator> ().enabled = true;
		health.SetActive (true);

	}

	public void Quit() {
		GameObject obj = GameObject.Find("head");
		SoundManager sound = obj.GetComponent<SoundManager> ();
		sound.button (transform.position);
		Application.Quit ();
	}
	public void Restart() {
		Application.LoadLevel (0);
	}


	}

