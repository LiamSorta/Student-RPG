using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    public float moveSpeed;
    Animator animator;

	void Start () {
        animator = GetComponent<Animator>();    
	}
    void Update()
    {
        GetComponent<SpriteRenderer>().sortingOrder = -Mathf.RoundToInt(transform.position.y * 100f);

    }
	void FixedUpdate () {

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
            transform.position += new Vector3(0, moveSpeed, 0);
            animator.SetInteger("walkDir", 3);
            animator.SetBool("isMoving", true);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -moveSpeed, 0);
            animator.SetInteger("walkDir", 1);
            animator.SetBool("isMoving", true);
        }

        else
            animator.SetBool("isMoving", false);

	}
}
