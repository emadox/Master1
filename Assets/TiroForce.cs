using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroForce : MonoBehaviour {

    public float speed;
    public Transform TiroSpawn;

	// Use this for initialization
	void Start () {
        speed = 120f;	
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 TiroDireccion = new Vector2(TiroSpawn.position.x * speed * Time.deltaTime, TiroSpawn.position.y);
	}
}
