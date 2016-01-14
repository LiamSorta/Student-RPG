using UnityEngine;
using System.Collections;

public class RMovement : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    //Edited by Adam O'Connor

    public float moveSpeed;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {

    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-moveSpeed, 0, 0);
            animator.SetInteger("walkDir", 2);
            animator.SetBool("isMoving", true);
            transform.localScale = new Vector3(1, 1, 1);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(moveSpeed, 0, 0);
            animator.SetInteger("walkDir", 2);
            animator.SetBool("isMoving", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("walkDir", 3);
            animator.SetBool("isMoving", true);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("walkDir", 1);
            animator.SetBool("isMoving", true);
        }

        else
            animator.SetBool("isMoving", false);

    }

}