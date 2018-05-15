using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour {

    public GameObject pelota;
    public Transform TiroSpawn;
    

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool shoot = Input.GetButtonDown("Fire1");

        if (shoot) Instantiate(pelota, TiroSpawn.position , TiroSpawn.rotation);
	}
}
