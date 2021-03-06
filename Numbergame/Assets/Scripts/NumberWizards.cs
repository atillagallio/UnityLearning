﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	private int max = 1000;
	private int min = 1;
	private int guess;

	// Use this for initialization
	void Start () {
		StartGame();

	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;

		print("Welcome to Number Wizard");
		print("Pick a number in your head but don't tell me :)");

		print("You should pick a number between " + min + " and " + max);

		print("Is the number higher or lower than " + guess + "?");
		print("Up arrow for higher, down for lower, return for equal");

		max = max + 1;

	}

	void NextGuess (){

		guess = (max + min)/2;
		print("Is the number higher or lower than " + guess + "?");
		print("Up arrow for higher, down for lower, return for equal");

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print("Up arrow pressed");
			min = guess;
			NextGuess();
		}else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print("Down arrow pressed");
			max = guess;
			NextGuess();
		}else if (Input.GetKeyDown (KeyCode.Return)) {
			print("I won :D");
			StartGame();
		}


	}
}
