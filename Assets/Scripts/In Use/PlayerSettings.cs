using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerSettings : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////`

    public State startState;
    GameObject player;
    Animator animator;
    

    public enum State
    {
        Up, Down, Left, Right   //Choose from one of these states in the inspector
    }

	void Start () {
        
        //Grabs the player animation component, sets the character facing direction depending on the enum state
        player = GameObject.FindGameObjectWithTag("Player");
        animator = player.GetComponent<Animator>();

        if(startState.ToString() == "Down")
            animator.SetInteger("walkDir", 1);
        if (startState.ToString() == "Up")
            animator.SetInteger("walkDir", 3);
        if (startState.ToString() == "Left")
        {
            animator.SetInteger("walkDir", 2);
            player.transform.localScale = new Vector3(1, 1, 1);
        }
        if (startState.ToString() == "Right")
        {
            animator.SetInteger("walkDir", 2);
            player.transform.localScale = new Vector3(-1, 1, 1);
        }
	}
}
