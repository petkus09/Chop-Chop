using UnityEngine;
using System.Collections;

public class ShieldPowerupTrigger : MonoBehaviour
{

    private playerControll playerController;
    private GameObject playerHead;
    // Use this for initialization
    void Start()
    {
        playerHead = GameObject.Find("head");
        if (playerHead != null)
        {
            playerController = playerHead.GetComponent<playerControll>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == playerHead)
        {
            playerController.AddProtection();
            Destroy(this.gameObject);
        }
    }
}
