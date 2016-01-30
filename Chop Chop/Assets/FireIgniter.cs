using UnityEngine;
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

    // Use this for initialization
    void Start()
    {
        GameObject headObjectFireParticles = GameObject.Find("HeadFireParticles");
        particlesOnDamage = headObjectFireParticles.GetComponentsInChildren<ParticleSystem>();
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
            if (firedSafeLength > saveLength)
            {
                dealtDamage = true;
                DamageDealtByFire();
            }
        }
    }

    void DamageDealtByFire()
    {
        foreach (ParticleSystem particle in particlesOnDamage)
        {
            particle.Stop();
            particle.Play();
        }
    }
}
