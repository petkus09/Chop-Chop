using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject head;
<<<<<<< HEAD

=======
>>>>>>> 66e1b8ce7c1c410b02534f71d698a932f599293f

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Slerp (new Vector3 (transform.position.x, transform.position.y, transform.position.z),
<<<<<<< HEAD

			new Vector3 (head.transform.position.x + 19f, head.transform.position.y + 13f, transform.position.z), 3 * Time.deltaTime);


=======
			new Vector3 (head.transform.position.x + 19f, head.transform.position.y + 13f , transform.position.z), 3 * Time.deltaTime);
>>>>>>> 66e1b8ce7c1c410b02534f71d698a932f599293f
	}
}
