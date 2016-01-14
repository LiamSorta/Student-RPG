//Jamie Cox 
//This code is the same as Answer 1
//With minor changes in referencing the variables form Answer1

using UnityEngine;
using System.Collections;

public class Answer2 : MonoBehaviour {
	
	public Control Stats2; 
	public Answer1 Stats;
	public bool Answer2State;
	
	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		//is marking if this box is selected



		if (Stats2.AnswerNo == 1) {
			Answer2State = false;
		}

		if (Stats2.AnswerNo == 2) {
						Answer2State = true;
				}

		if (Stats2.AnswerNo == 3) {
			Answer2State = false;
				}

		if (Stats2.AnswerNo == 4) {
			Answer2State = false;
		}
		
		//Runs the functions to run each question in order
		
		if (Stats.QuestionNumber == 1) {
			
			Q1();
			return;

		}
		
		if (Stats.QuestionNumber == 2) {
			
			Q2 ();
			return;


		}
		
		if (Stats.QuestionNumber == 3) {
			
			Q3 ();
			return;

		}
		
		if (Stats.QuestionNumber == 4) {
			
			Q4 ();
			return;

		}

		if (Stats.QuestionNumber == 5) {
			
			Q5 ();
			return;
			
		}
		
		if (Stats.QuestionNumber == 6) {
			
			Q6 ();
			return;
			
		}

		if (Stats.QuestionNumber == 7) {
			
			Q7 ();
			return;
			
		}

		if (Stats.QuestionNumber == 8) {
			
			Q8 ();
			return;
			
		}

		if (Stats.QuestionNumber == 9) {
			
			Q9 ();
			return;
			
		}

		if (Stats.QuestionNumber == 10) {
			
			Q10 ();
			return;
			
		}
	}
	void Q1(){
		if(Stats.QuestionNumber==1 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true) 
		{
			
			

			Stats.QuestionNumber = 2;
			
		}
	}
	
	void Q2(){
		if(Stats.QuestionNumber==2 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{
			Stats.correct = Stats.correct+1;
			Stats.QuestionNumber =3;
			
		}
	}
	
	void Q3(){
		if(Stats.QuestionNumber==3 && Input.GetKeyUp(KeyCode.E)&& Answer2State == true)
		{
			
			Stats.QuestionNumber =4;
			
		}
	}
	
	void Q4(){
		if(Stats.QuestionNumber==4 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{
			
			Stats.QuestionNumber =5;
			
		}
	}

	void Q5(){
		if(Stats.QuestionNumber==5 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{
			Stats.correct = Stats.correct+1;
			Stats.QuestionNumber =6;

		}
	}

	void Q6(){
		if(Stats.QuestionNumber==6 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{

			Stats.QuestionNumber =7;
			return;
		}
	}
	
	void Q7(){
		if(Stats.QuestionNumber==7 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{
			Stats.smartArse =Stats.smartArse+1;
			Stats.QuestionNumber =8;
			return;
		}
	}
	
	void Q8(){
		if(Stats.QuestionNumber==8 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{

			Stats.QuestionNumber = 9;
			return;
		}
	}
	
	void Q9(){
		if(Stats.QuestionNumber==9 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{
			
			Stats.QuestionNumber =10;
			return;
		}
	}
	
	void Q10(){
		if(Stats.QuestionNumber==10 && Input.GetKeyUp (KeyCode.E)&& Answer2State == true)
		{

			Stats.QuestionNumber =11;
			return;
		}
	}
	
}
