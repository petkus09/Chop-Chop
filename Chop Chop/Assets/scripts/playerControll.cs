using UnityEngine;
using System.Collections;

public class playerControll : MonoBehaviour {


	public float minHeigth = 2.5f;
	public float maxheigth = 12f;
	public ParticleSystem blood;
	private bool canJump = true;
	public float maxVelocity = 30;
    public float stoneCollisionMagnitudeThreshold = 15;
	public GameObject shieldBubble;
	private bool underProtection = false;
	private float lastCollisionTimestamp = 0;
	public int bumpsCount = 0;

	public int healthLeft = 3;
	public bool dead = false;
	
	// Update is called once per frame
	void FixedUpdate () {
		
			GetComponent<Rigidbody> ().AddForce (new Vector3 (1.5f, -0.5f, 0));

		GetComponent<Rigidbody> ().velocity = Vector3.ClampMagnitude (GetComponent<Rigidbody> ().velocity, maxVelocity);
		if (Input.GetKeyDown ("up") && canJump == true) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0,1100,0));
			canJump = false;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 14));
		
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, -14));

		}
		var pos = transform.position;
		pos.z = Mathf.Clamp (transform.position.z, -8, 8);
		transform.position = pos;
	}
	void OnCollisionEnter(Collision col) {
		SoundManager sound = gameObject.GetComponent<SoundManager> ();
		sound.headBump (transform.position);
		bumpsCount++;
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 150, 0));
		if (!underProtection)
			blood.Emit (30);
		canJump = true;
	    float magnitude = col.relativeVelocity.magnitude;
        if (col.gameObject.tag == "vaze") {
			if (DamageInitializer())
			{
				DealDamage();
			}
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
				if (DamageInitializer())
				{
					DealDamage();
				}
            }

        }
		//lastCollisionTimestamp = Time.fixedTime;
    }
	 public void OnTriggerEnter(Collider col) {
		if (!underProtection)
			blood.Emit (30);
	

		if (col.gameObject.tag == "vaze") {
			Instantiate (Resources.Load ("vazeCrash"), transform.position, transform.rotation);
			Destroy (col.gameObject);
			if (DamageInitializer())
			{
				DealDamage();
			}

		}
		if (col.gameObject.tag == "arrow") {
			Debug.Log ("ARROW");
			if (DamageInitializer())
			{
				DealDamage();
			}
		}
	} 

	public void DealDamage()
	{
		if (!dead) {
			healthLeft--;

			if (healthLeft < 1) {
				dead = true;
			}
		}
	}

	public void AddProtection()
	{
		shieldBubble.SetActive(true);
		underProtection = true;
	}

	public void RemoveProtection()
	{
		shieldBubble.SetActive(false);
		underProtection = false;
	}

	public bool DamageInitializer()
	{
		bool toApplyDamage = true;
		//if (Time.fixedTime - lastCollisionTimestamp > 0.5)
		//{
			if (underProtection)
			{
				toApplyDamage = false;
				RemoveProtection();
			}
		//}
		//else
		//{
		//	toApplyDamage = false;
		//}
		return toApplyDamage;
	}

}
