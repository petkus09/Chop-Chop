using UnityEngine;
using System.Collections;

public class turret : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.right * -45 * Time.deltaTime);
		if (transform.position.z < -20) {
			transform.position = new Vector3(transform.position.x, transform.position.y,9);
		}
	}
}
