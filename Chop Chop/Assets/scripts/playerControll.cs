using UnityEngine;
using System.Collections;

public class playerControll : MonoBehaviour {


	public float minHeigth = 2.5f;
	public float maxheigth = 12f;
	public ParticleSystem blood;
	private bool canJump = true;
	public float maxVelocity = 30;
    public float stoneCollisionMagnitudeThreshold = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		GetComponent<Rigidbody> ().AddForce (new Vector3 (2,0,0));
		GetComponent<Rigidbody> ().velocity = Vector3.ClampMagnitude (GetComponent<Rigidbody> ().velocity, maxVelocity);
		if (Input.GetKeyDown ("up") && canJump == true) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0,1100,0));
			canJump = false;
		}

	}
	void OnCollisionEnter(Collision col) {
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 250, 0));
		blood.Emit (30);
		canJump = true;
	    float magnitude = col.relativeVelocity.magnitude;
        if (col.gameObject.tag == "vaze") {
			Instantiate (Resources.Load ("vazeCrash"), transform.position, transform.rotation);
			Destroy (col.gameObject);
		}
	    if (col.gameObject.tag == "stone")
	    {
	        if (magnitude > stoneCollisionMagnitudeThreshold)
	        {
	            ParticleSystem stoneParticleSystem = col.gameObject.GetComponent<ParticleSystem>();
	            if (stoneParticleSystem != null)
	            {
	                stoneParticleSystem.Stop();
                    stoneParticleSystem.Play();
	            }
                // DO DAMAGE
            }

        }

    }
	 public void OnTriggerEnter(Collider col) {
		
		blood.Emit (30);
	

		if (col.gameObject.tag == "vaze") {
			Instantiate (Resources.Load ("vazeCrash"), transform.position, transform.rotation);
			Destroy (col.gameObject);
			GameObject canvas = GameObject.Find ("score / health Canvas");
			scoreHealthCanvas script = canvas.GetComponent<scoreHealthCanvas>();
			script.healthLeft -= 1;
		}
	} 


}
