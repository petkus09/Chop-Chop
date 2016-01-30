using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject head;
<<<<<<< HEAD
=======
	Vector3 lastPosition = Vector3.zero;
>>>>>>> 6b3be8927b7ac0ed33c809bd9fbecaa156ffa846

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Slerp (new Vector3 (transform.position.x, transform.position.y, transform.position.z),
<<<<<<< HEAD
			new Vector3 (head.transform.position.x + 19f, head.transform.position.y + 13f , transform.position.z), 3 * Time.deltaTime);

			


=======
			new Vector3 (head.transform.position.x + 19f, head.transform.position.y +13f , transform.position.z), 5 * Time.deltaTime);
>>>>>>> 6b3be8927b7ac0ed33c809bd9fbecaa156ffa846
	}
}
