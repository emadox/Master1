using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroForce : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        speed = 120f;	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;

        position = new Vector2(position.x + speed * Time.deltaTime, position.y);

		transform.position = position ;
	}
}
