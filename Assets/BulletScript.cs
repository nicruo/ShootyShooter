using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 1000);
        Destroy(gameObject, 2);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyScript>().DamageTaken(50);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
