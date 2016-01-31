using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour {

	public float soundlevel = 1;

	int x = 0;

	//AudioClip clips
	public List<AudioClip> sounds;
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (sounds [0], 0.7f * soundlevel);
	}

	void Update() {
		x = (int)(transform.position.x / 1f);
	}

	public void vaze(Vector3 position) {
		int objX = (int)(position.x / 1f);
		if (Mathf.Abs(objX - x) < 10)
			audioSource.PlayOneShot (sounds [Random.Range(1,4)], 1 * soundlevel);
	}

	public void fireball(Vector3 position) {
		int objX = (int)(position.x / 1f);
		if (Mathf.Abs(objX - x) < 10)
		audioSource.PlayOneShot (sounds [4], 0.8f * soundlevel);
	}
	public void arrow(Vector3 position) {
		int objX = (int)(position.x / 1f);
		if (Mathf.Abs(objX - x) < 10)
			audioSource.PlayOneShot (sounds [Random.Range(5,9)], 1 * soundlevel);
	}
	public void headCut(Vector3 position) {
		int objX = (int)(position.x / 1f);
		if (Mathf.Abs(objX - x) < 10)
			audioSource.PlayOneShot (sounds [9], 1 * soundlevel);
	}
	public void headBump(Vector3 position) {
		int objX = (int)(position.x / 1f);
		if (Mathf.Abs(objX - x) < 10)
			audioSource.PlayOneShot (sounds [10], 1 * soundlevel);
	}
	public void button(Vector3 position) {
		
			audioSource.PlayOneShot (sounds [11], 2 * soundlevel);
	}

}
