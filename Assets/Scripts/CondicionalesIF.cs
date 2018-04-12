using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionalesIF : MonoBehaviour {

	public int valorEntero = 15;
	public float valorDecimal = 16.3f;

	void Start () {
	
		if(valorEntero >= 15){
			Debug.Log ("Es mayor a 15");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
