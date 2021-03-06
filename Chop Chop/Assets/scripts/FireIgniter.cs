﻿using UnityEngine;
using System.Collections;

public class FireIgniter : MonoBehaviour
{

    public ParticleSystem fireParticle;
    private float lifespan;
    private bool isFired = false;
    public float fireIntervalInSeconds;
//    public ParticleCollisionEvent[] collisionEvents;
    public int saveLength;
    private bool dealtDamage = false;
    private ParticleSystem[] particlesOnDamage;
    private playerControll _controller;

    // Use this for initialization
    void Start()
    {
        GameObject headObjectFireParticles = GameObject.Find("HeadFireParticles");
        particlesOnDamage = headObjectFireParticles.GetComponentsInChildren<ParticleSystem>();
        GameObject headObject = GameObject.Find("head");

        if (headObject != null)
        {
			_controller = headObject.GetComponent<playerControll>();
        }
//        collisionEvents = new ParticleCollisionEvent[saveLength];
//	    lifespan = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        lifespan = Mathf.Round(Time.fixedTime)%fireIntervalInSeconds;
        if (lifespan < 1)
        {
            if (!isFired)
            {
				GameObject obj = GameObject.Find("head");
				SoundManager sound = obj.GetComponent<SoundManager> ();
				sound.fireball (transform.position);

                fireParticle.Stop();
                fireParticle.Play();
                isFired = true;
            }
        }
        else
        {
            fireParticle.Stop();
            isFired = false;
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (!dealtDamage)
        {
            int firedSafeLength = fireParticle.GetSafeCollisionEventSize();
			Debug.Log (firedSafeLength);
            if (firedSafeLength > saveLength)
            {
				
                dealtDamage = true;
                DamageDealtByFire();

            }
        }
    }

    void DamageDealtByFire()
    {
		Debug.Log (particlesOnDamage.Length);
		Debug.Log (_controller);
		if (_controller != null)
		{
			if (_controller.DamageInitializer ()) {
		        foreach (ParticleSystem particle in particlesOnDamage)
		        {
		            

					particle.Stop();
					particle.Play();

				}

				_controller.DealDamage ();
            }
        }
    }
}
