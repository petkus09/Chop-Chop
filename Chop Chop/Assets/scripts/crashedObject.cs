using UnityEngine;
using System.Collections;

public class crashedObject : MonoBehaviour {


	private float timer = 6f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 2) {
			GetComponent<Rigidbody> ().drag = 3;
			GetComponent<MeshCollider> ().enabled = false;


		}
		if (timer <= 0) {
			Destroy (gameObject);
		}
	}
}
