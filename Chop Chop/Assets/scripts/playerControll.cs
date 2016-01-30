using UnityEngine;
using System.Collections;

public class playerControll : MonoBehaviour {


	public float minHeigth = 2.5f;
	public float maxheigth = 12f;
	public ParticleSystem blood;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown ("up")) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0,600,0));
		}

	}
	void OnCollisionEnter(Collision col) {
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 250, 0));
		blood.Emit (30);

	}

}
