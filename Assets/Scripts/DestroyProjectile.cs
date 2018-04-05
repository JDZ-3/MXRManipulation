using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {

    private float projectile_emitted_time;
    public float projectile_duration = 7.0f;

	// Use this for initialization
	void Start () {
        projectile_emitted_time = Time.fixedTime;

	}
	
	// Update is called once per frame
	void Update () {
        if (Time.fixedTime - projectile_emitted_time > projectile_duration) {
            Destroy(this.gameObject);
        }
	}
}
