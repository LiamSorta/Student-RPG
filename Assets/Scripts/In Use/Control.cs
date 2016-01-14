//Jamie Cox
using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
	public int AnswerNo;
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public Sprite check;
	public Sprite unChecked;
	public Sprite Gone;
	public Answer1 QuestionNo;


	// Use this for initialization
	void Start () {
	
		AnswerNo = 1;
	}
	
	// Update is called once per frame
	void Update () {

		Glow ();

		if (Input.GetKeyDown (KeyCode.S)) {
			AnswerNo = AnswerNo + 1;
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			AnswerNo = AnswerNo - 1;
		}

		if (AnswerNo == 0) {
			AnswerNo = 4;
	
		}

		if (AnswerNo == 5) {
			AnswerNo = 1;
			
		}

		if (QuestionNo.QuestionNumber == 11) {

			GameObject one = GameObject.Find ("Answer1");
			one.GetComponent<SpriteRenderer> ().sprite = Gone;
			
			GameObject two = GameObject.Find ("Answer2");
			two.GetComponent<SpriteRenderer> ().sprite = Gone;
			
			GameObject three = GameObject.Find ("Answer3");
			three.GetComponent<SpriteRenderer> ().sprite = Gone;
			
			GameObject four = GameObject.Find ("Answer4");
			four.GetComponent<SpriteRenderer> ().sprite = Gone;

		}
	}

	void Glow(){
		
		//sets the sprite for the cube based on whats selected
		if (AnswerNo == 1) {
			GameObject one = GameObject.Find ("Answer1");
			one.GetComponent<SpriteRenderer>().sprite = check;
			
			GameObject two = GameObject.Find ("Answer2");
			two.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject three = GameObject.Find ("Answer3");
			three.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject four = GameObject.Find ("Answer4");
			four.GetComponent<SpriteRenderer>().sprite = unChecked;
		}
		
		if (AnswerNo == 2) {
			
			GameObject one = GameObject.Find ("Answer1");
			one.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject two = GameObject.Find ("Answer2");
			two.GetComponent<SpriteRenderer>().sprite = check;
			
			GameObject three = GameObject.Find ("Answer3");
			three.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject four = GameObject.Find ("Answer4");
			four.GetComponent<SpriteRenderer>().sprite = unChecked;
		}
		
		if (AnswerNo == 3) {
			
			GameObject one = GameObject.Find ("Answer1");
			one.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject two = GameObject.Find ("Answer2");
			two.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject three = GameObject.Find ("Answer3");
			three.GetComponent<SpriteRenderer>().sprite = check;
			
			GameObject four = GameObject.Find ("Answer4");
			four.GetComponent<SpriteRenderer>().sprite = unChecked;
		}
		
		if (AnswerNo == 4) {

			GameObject one = GameObject.Find ("Answer1");
			one.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject two = GameObject.Find ("Answer2");
			two.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject three = GameObject.Find ("Answer3");
			three.GetComponent<SpriteRenderer>().sprite = unChecked;
			
			GameObject four = GameObject.Find ("Answer4");
			four.GetComponent<SpriteRenderer>().sprite = check;
		}
	}

}
