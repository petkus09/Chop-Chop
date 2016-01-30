using UnityEngine;
using System.Collections;

public class stoneExploder : MonoBehaviour
{

    public Rigidbody rigidl;
    public float forceMultiplier;
    // Use this for initialization
    void Start ()
	{
	    
//        rigidl.AddExplosionForce(Random.Range(0, 5000), new Vector3(0, 0, 0), Random.Range(0, 20), Random.Range(0, 20));
    }
	
	// Update is called once per frame
	void Update () {
	    
    }

    void ActivateIt()
    {
        rigidl.AddForce(transform.right * rigidl.mass * forceMultiplier);
    }
}
