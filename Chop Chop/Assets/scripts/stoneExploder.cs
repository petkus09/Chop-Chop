using UnityEngine;
using System.Collections;

public class stoneExploder : MonoBehaviour
{

    public Rigidbody rigidl;
    public float forceMultiplier;
	private float timer = 15f;
    // Use this for initialization
    void Start ()
	{
		ActivateIt ();
		//rigidl.AddExplosionForce(Random.Range(0, 5000), new Vector3(0, 0, 0), Random.Range(0, 20), Random.Range(0, 20));
    }


	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 2) {
			GetComponent<Rigidbody> ().drag = 1;
			GetComponent<MeshCollider> ().enabled = false;
		}
		if (timer <= 0) {
			Destroy (gameObject);
		}
	}

    void ActivateIt()
    {
        rigidl.AddForce(transform.right * rigidl.mass * forceMultiplier);
    }
}
