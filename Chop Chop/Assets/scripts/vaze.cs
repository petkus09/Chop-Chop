using UnityEngine;
using System.Collections;

public class vaze : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision col) {
		
			if (col.relativeVelocity.magnitude >= 9) {
			GameObject obj = GameObject.Find("head");
			SoundManager sound = obj.GetComponent<SoundManager> ();
			sound.vaze (transform.position);
				Instantiate (Resources.Load ("vazeCrash"), transform.position, transform.rotation);

				Destroy (gameObject);
				
			}


}
}