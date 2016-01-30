using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject head;
	Vector3 lastPosition = Vector3.zero;
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
		var a = Vector3.Distance (lastPosition, transform.position);
		Debug.Log (a);
		lastPosition = head.transform.position;
>>>>>>> 672f782d971cf93dfaaf57cb4505893a13e753db
	}
}
