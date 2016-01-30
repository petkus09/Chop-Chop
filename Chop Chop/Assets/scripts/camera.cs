using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject head;
<<<<<<< HEAD

=======
>>>>>>> b40cb3ffd144db26f3f36358d9c3b55140a6319b

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Slerp (new Vector3 (transform.position.x, transform.position.y, transform.position.z),
<<<<<<< HEAD


			new Vector3 (head.transform.position.x + 19f, head.transform.position.y + 13f, transform.position.z), 3 * Time.deltaTime);


=======

			new Vector3 (head.transform.position.x + 19f, head.transform.position.y + 13f, transform.position.z), 3 * Time.deltaTime);
>>>>>>> b40cb3ffd144db26f3f36358d9c3b55140a6319b
	}
}
