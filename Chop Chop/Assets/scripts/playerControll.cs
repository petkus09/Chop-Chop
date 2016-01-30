using UnityEngine;
using System.Collections;

public class playerControll : MonoBehaviour {


	public float minHeigth = 2.5f;
	public float maxheigth = 12f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown ("up")) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0,200,0));
		}
	}
}
