using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

    private Rigidbody body;
    public float movementSpeed = 10;

    public float maxHealth = 100;
    public float currentHealth = 100;

    public Text healthText;

    public void DamageTaken(float damage)
    {
        currentHealth -= damage;
        healthText.text = currentHealth + "";
    }

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();

        healthText = transform.GetComponentInChildren<Text>();

        healthText.text = currentHealth + "";
	}
	
	// Update is called once per frame
	void Update () {
        if(currentHealth <= 0)
        {
            DestroyImmediate(gameObject);
        }
	}

    private void FixedUpdate()
    {
        body.AddForce(transform.forward * movementSpeed);
    }
}
