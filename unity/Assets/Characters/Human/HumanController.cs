using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController.cs : MonoBehaviour {

	Animator animator

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		// convert direction to polar
		Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

	}
}
