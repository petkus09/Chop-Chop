using UnityEngine;
using System.Collections;

public class rollHead : MonoBehaviour {

	public GameObject ps;

	void Start() {
		
	}

	public void go() {
		GameObject obj = GameObject.Find("head");
		SoundManager sound = obj.GetComponent<SoundManager> ();
		sound.headCut (transform.position);

		GameObject head = GameObject.Find ("head");
		head.GetComponent<Rigidbody> ().isKinematic = false;
		ps.GetComponent<ParticleSystem> ().Play ();
	}
}
