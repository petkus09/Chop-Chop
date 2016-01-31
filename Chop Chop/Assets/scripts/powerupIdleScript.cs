using UnityEngine;
using System.Collections;

public class powerupIdleScript : MonoBehaviour
{

    public float movementOffset;
    private Vector3 originalPosition;
    private Transform thisTransform;
	// Use this for initialization
	void Start ()
	{
	    thisTransform = this.gameObject.GetComponent<Transform>();
	    originalPosition = thisTransform.localPosition;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    LiftObject();
	    RotateObject();
	}

    void LiftObject()
    {
        float sinValue = Mathf.Sin(Time.fixedTime);
        float relativePosOffset = movementOffset * sinValue;
        thisTransform.localPosition = new Vector3(originalPosition.x, originalPosition.y + relativePosOffset, originalPosition.z);
    }

    void RotateObject()
    {
        thisTransform.Rotate(new Vector3(0, 1, 0));
//        thisTransform.Rotate(new Vector3(thisTransform.localRotation.x, thisTransform.localRotation.y + 1, thisTransform.localRotation.z));
    }
}
