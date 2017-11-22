using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {
	private GameObject thePlayer;
	private Component playerHealth;

	void Start () {
		thePlayer = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = thePlayer.GetComponent<PlayerHealth>();
	}
	

	void Update () {
		
	}
}
