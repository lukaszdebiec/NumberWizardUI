﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {


	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10;

	public Text text;


	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame ()
	{
	max = 10001;
	min = 1;
	NextGuess();

	}

	void NextGuess ()
	{
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
		Application.LoadLevel("Win");
	}
	}


	// Update is called once per frame

	public void GuessHigher () {
		min=guess;
		NextGuess ();
	}

	public void GuessLower () {
		max=guess;
		NextGuess ();
	}




}
