using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		startGame ();
	}
	
	void nextGuess(){
		guess = (max + min)/2;
		print ("Higher or lower than "+guess);
	}
	
	// Update is called once per frame
	void Update () {	
		if(Input.GetKeyUp(KeyCode.UpArrow)){
			min = guess;
			nextGuess ();
		}
		
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			nextGuess ();

		}
		
		else if(Input.GetKeyDown(KeyCode.Return)){
			print ("I won!");
			delay(2);
			clearConsole();
			startGame();
		}
		
		/*else{
			print ("Press a valid key");
			print ("Up = higher | Down = lower | Return = equal");
		}*/
	}
	
	void startGame(){
		max = 1000; min = 1; guess=500;
		print ("Welcome to number Wizard");
		print ("Pick a number in your head, but don't tell me");
		
		print ("Choose a number between "+min+" and "+max);
		
		print ("Up = higher | Down = lower | Return = equal");
		print ("Is the number higher or lower than 500?");
		
		max +=1;
	}
	
	void clearConsole(){
		var logEntries = System.Type.GetType("UnityEditorInternal.LogEntries,UnityEditor.dll");
		var clearMethod = logEntries.GetMethod("Clear", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
		clearMethod.Invoke(null,null);
	}
	
	IEnumerator delay(int seconds)
	{
		yield return new WaitForSeconds(seconds);
	}
}
