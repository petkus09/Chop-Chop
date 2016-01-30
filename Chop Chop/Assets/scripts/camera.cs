using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject head;
<<<<<<< HEAD

=======
>>>>>>> fc681e501ed9ffa5e602114f7ea0e043b812155c

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Slerp (new Vector3 (transform.position.x, transform.position.y, transform.position.z),
<<<<<<< HEAD
=======
			new Vector3 (head.transform.position.x + 19f, head.transform.position.y + 13f , transform.position.z), 3 * Time.deltaTime);
>>>>>>> fc681e501ed9ffa5e602114f7ea0e043b812155c

			new Vector3 (head.transform.position.x + 28f, head.transform.position.y + 9f , transform.position.z), 3 * Time.deltaTime);

<<<<<<< HEAD

=======
>>>>>>> fc681e501ed9ffa5e602114f7ea0e043b812155c
	}
}
