using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour {

    public Rigidbody2D pelota;
    public float speedforce = 12f;

    void tirito()
    {
        Rigidbody2D pelotaClon = (Rigidbody2D)Instantiate(pelota, transform.position, transform.rotation);
        pelotaClon.velocity = new Vector2 (5 * speedforce, 0);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            tirito();
        }    
	}
}
