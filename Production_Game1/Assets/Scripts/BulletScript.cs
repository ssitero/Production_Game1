using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float speed = 8f;
    public float lifetime = 2f;

    private float lifeTimer;
	// Use this for initialization
	void Start () {
        lifeTimer = lifetime;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f){
            Destroy(gameObject);
        }
    }
}
