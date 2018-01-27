﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonnageController : MonoBehaviour {

	private PersonnageModel model;
	//Zak
	//Zak
	void Awake(){
		model = this.gameObject.GetComponent<PersonnageModel> ();
	}

	// Use this for initialization

	void Start () {
		model.sprite = this.gameObject.GetComponent<SpriteRenderer> ();
		model.shootPoint = transform.FindChild ("ShootPoint");

		model.power = this.gameObject.GetComponent<Power> ();

		//Zak
		//Zak
	}
	
	// Update is called once per frame
	void Update () {

		float translation = Time.deltaTime * model.moveSpeed;

		if (Input.GetKey (KeyCode.Space)) {
			this.throwPower ();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3 (-translation, 0, 0));

			Vector3 newScale = transform.localScale;
			newScale.x *= -newScale.x;
			transform.localScale = newScale;

		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (translation, 0, 0));

			Vector3 newScale = transform.localScale;
			newScale.x *= newScale.x;
			transform.localScale = newScale;


		} 

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (new Vector3 (0, translation, 0));
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (new Vector3 (0, -translation, 0));
		}
		//Zak
		//Zak
		
	}

	void throwPower(){
		if (model.power != null) {
			model.power.direction = (int) transform.localScale.x;
			Instantiate (model.power, model.shootPoint.position, model.shootPoint.rotation);
			model.power = null;
		}
	}
		
	
}