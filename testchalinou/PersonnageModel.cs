﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonnageModel : MonoBehaviour {

	//Zak
	/*public float bonusMooveSpeed;
	public float malusMooveSpeed;*/
	//Zak
	public float percentage;
	public float attackSpeed;
	public float moveSpeed;
	public int life;
	public bool isShooting { get; set;}
	public BonusThrowedScript power;
	public Tir tir;
	public bool isMoving  { get; set;}
	public bool isAttacking  { get; set;}
	public SpriteRenderer sprite { get; set;}
	public Transform shootPoint;
	public float fireRate = 0;
	public float timeToFire = 0;
	public float damage = 5;
	public bool hasBonus = false;
	public Animator anim { get; set; }

	public float numeroJoueur = 1;


	//Zak
	//Zak


}
