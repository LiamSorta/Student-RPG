//Jamie Cox
//This code is the same as Answer 1
//With minor changes in referencing the variables form Answer1
using UnityEngine;
using System.Collections;

public class Answer1 : MonoBehaviour {

	public int QuestionNumber;
	public int correct;
	public int smartArse;

	public Control Stats2; 
	public bool Answer1State;
	public GameObject Question;
	public TextWriter Done;

	public Sprite q1;
	public Sprite q2;
	public Sprite q3;
	public Sprite q4;
	public Sprite q5;
	public Sprite q6;
	public Sprite q7;
	public Sprite q8;
	public Sprite q9;
	public Sprite q10;

	public Sprite r0;
	public Sprite r1;
	public Sprite r2;
	public Sprite r3;
	public Sprite r4;
	public Sprite r5;
	public Sprite r6;
	public Sprite r7;
	public Sprite r8;
	public Sprite r9;
	public Sprite r10;

	// Use this for initialization
	void Start () {
	
		QuestionNumber = 1;
		correct = 0;
		smartArse = 0;
		GameObject Question = GameObject.Find ("Q1-Q1");
		Question.GetComponent<SpriteRenderer>().sprite = q1;
	}
	
	// Update is called once per frame
	void Update () {
				
		
		//is marking if this box is selected
		
		if (Stats2.AnswerNo == 1) {
			Answer1State = true;
		}
		
		if (Stats2.AnswerNo == 2) {
			Answer1State = false;
		}

		if (Stats2.AnswerNo == 3) {
			Answer1State = false;
		}

		if (Stats2.AnswerNo == 4) {
			Answer1State = false;
		}



		//Runs the functions to run each question in order
		
		if (QuestionNumber == 1) {
		
			Q1();
			return;

		}
		        
		if (QuestionNumber == 2) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q2;

			Q2 ();
			return;


		}

	if (QuestionNumber == 3) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q3;

			Q3 ();
			return;

				}

		if (QuestionNumber == 4) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q4;

			Q4 ();
			return;

		}

		if (QuestionNumber == 5) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q5;

			Q5();
			return;
				}
		if(QuestionNumber == 6){
			//Debug.Log (correct);
		}

		if (QuestionNumber == 6) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q6;
			
			Q6();
			return;
		}
		if(QuestionNumber == 6){
			//Debug.Log (correct);
		}

		if (QuestionNumber == 7) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q7;
			
			Q7();
			return;
		}
		if(QuestionNumber == 7){
			//Debug.Log (correct);
		}


		if (QuestionNumber == 8) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q8;
			
			Q8();
			return;
		}
		if(QuestionNumber == 8){
			//Debug.Log (correct);
		}

		if (QuestionNumber == 9) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = q9;
			
			Q9();
			return;
		}
		if(QuestionNumber == 9){
			//Debug.Log (correct);
		}

		if (QuestionNumber == 10) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer> ().sprite = q10;
			
			Q10 ();
			return;
		}

		//If all the questions are answered run the answer algorithm 
		if (QuestionNumber == 11) {
			Results();
		}


		//Voids to store functions for each question
}

		void Q1(){
		if(QuestionNumber==1 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true) 
			{
				
				
				correct = correct + 1;
				QuestionNumber = 2;
			return;
			}
		}

		void Q2(){
		if(QuestionNumber==2 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
			{
			smartArse= smartArse+ 1;
				QuestionNumber =3;
			return;
			}
		}

	void Q3(){
		if(QuestionNumber==3 && Input.GetKeyUp(KeyCode.E)&& Answer1State == true)
		{
			smartArse= smartArse+ 1;
			QuestionNumber =4;
			return;
		}
	}

	void Q4(){
		if(QuestionNumber==4 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{
			
			QuestionNumber =5;
			return;
		}
	}

	void Q5(){
		if(QuestionNumber==5 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{
			smartArse= smartArse+1;
			QuestionNumber =6;
			return;
		}
	}

	void Q6(){
		if(QuestionNumber==6 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{
			correct = correct +1;
			QuestionNumber =7;
			return;
		}
	}

	void Q7(){
		if(QuestionNumber==7 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{
			QuestionNumber =8;
			return;
		}
	}

	void Q8(){
		if(QuestionNumber==8 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{

			QuestionNumber =9;
			return;
		}
	}

	void Q9(){
		if(QuestionNumber==9 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{

			QuestionNumber =10;
			return;
		}
	}

	void Q10(){
		if(QuestionNumber==10 && Input.GetKeyUp (KeyCode.E)&& Answer1State == true)
		{
			smartArse= smartArse+1;
			QuestionNumber =11;
			return;
		}
	}

	//This function is to determine which end screen to show
	void Results(){


		//removing the buttons
		if (correct == 0) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r0;
            Achievements.failTheClass = true;
		}

		if (correct == 1) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r1;
            Achievements.failTheClass = true;
		}

		if (correct == 2) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r2;
            Achievements.failTheClass = true;
		}

		if (correct == 3) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r3;
            Achievements.failTheClass = true;
		}

		if (correct == 4) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r4;
		}

		if (correct == 5) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r5;
		}

		if (correct == 6) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r6;
		}

		if (correct == 7) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r7;
            Achievements.getAFirst = true;
		}

		if (correct == 8) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r8;
            Achievements.getAFirst = true;
		}

		if (correct == 9) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r9;
            Achievements.getAFirst = true;
		}

		if (correct == 10) {
			GameObject Question = GameObject.Find ("Q1-Q1");
			Question.GetComponent<SpriteRenderer>().sprite = r10;
            Achievements.getAFirst = true;
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			Application.LoadLevel("Classroom");
		}




	}
}
