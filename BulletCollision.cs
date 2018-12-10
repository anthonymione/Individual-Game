using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.transform.name);
        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
