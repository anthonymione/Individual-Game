using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgun : MonoBehaviour {
    public Rigidbody bulletPrefab;
    public Transform gunEnd;
    public Animator anin;
    //public float damage = 10f;

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation) as Rigidbody;
            bulletInstance.AddForce(gunEnd.forward * 5000);

            anin.Play("Shotgun");
        }

    }
}
