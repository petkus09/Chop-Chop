using UnityEngine;
using System.Collections;

public class playerControll : MonoBehaviour {


	public float minHeigth = 2.5f;
	public float maxheigth = 12f;
	public ParticleSystem blood;
	private bool canJump = true;
	public float maxVelocity = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		GetComponent<Rigidbody> ().AddForce (new Vector3 (2,0,0));
		GetComponent<Rigidbody> ().velocity = Vector3.ClampMagnitude (GetComponent<Rigidbody> ().velocity, maxVelocity);
		if (Input.GetKeyDown ("up") && canJump == true) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0,1100,0));
			canJump = false;
		}

	}
	void OnCollisionEnter(Collision col) {
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 250, 0));
		blood.Emit (30);
		canJump = true;
		if (col.gameObject.tag == "vaze") {
			Instantiate (Resources.Load ("vazeCrash"), transform.position, transform.rotation);
			Destroy (col.gameObject);
		
		}
	}


}
