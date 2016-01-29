using UnityEngine;
using System.Collections;

public class playerControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0.5f * Time.deltaTime, 0, 0));
		if (Input.GetKeyDown ("up")) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0,200,0));
		}
	}
}
