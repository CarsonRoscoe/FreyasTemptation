﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Button function to start the game with level 0.
	public void StartGame(){
		Application.LoadLevel(1);
		Time.timeScale = 1;
	}

	// Button fucntion to quit the game.
	public void QuitGame(){
		Application.Quit ();
	}
}
