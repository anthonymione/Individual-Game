using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Rigidbody bulletPrefab;
    public Transform gunEnd;
    public Animator anin;
    //public float damage = 10f;

	// Update is called once per frame
	void Update () {
        
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation) as Rigidbody;
            bulletInstance.AddForce(gunEnd.forward * 5000);

            anin.Play("Outer_Case");
        }
        

    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "hand")
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                Rigidbody bulletInstance;
                bulletInstance = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation) as Rigidbody;
                bulletInstance.AddForce(gunEnd.forward * 5000);

                anin.Play("Outer_Case");
            }
        }
    }
    */
}
