using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    Vector2 lineStart, lineEnd1, lineEnd2, lineEnd3, lineEnd4; //Casting for interation
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
	void Update () {

            

        if (Input.GetKeyDown(KeyCode.E))
        {
            lineStart = new Vector2(transform.position.x, (transform.position.y - (GetComponent<SpriteRenderer>().bounds.extents.y /2))); //Starts in centre of character
            lineEnd1 = new Vector2(0, 20);                                        //Direction of cast
            lineEnd2 = new Vector2(0, -20);
            lineEnd3 = new Vector2(20, 0);
            lineEnd4 = new Vector2(-20, 0);

            RaycastHit2D hit = Physics2D.Raycast(lineStart, lineEnd1, 10f, 1 << LayerMask.NameToLayer("Interactables"));        //Casting, length of 2
            RaycastHit2D hit2 = Physics2D.Raycast(lineStart, lineEnd2, 10f, 1 << LayerMask.NameToLayer("Interactables"));
            RaycastHit2D hit3 = Physics2D.Raycast(lineStart, lineEnd3, 10f, 1 << LayerMask.NameToLayer("Interactables"));
            RaycastHit2D hit4 = Physics2D.Raycast(lineStart, lineEnd4, 10f, 1 << LayerMask.NameToLayer("Interactables"));

            Debug.DrawRay(lineStart, new Vector3(0, 20), Color.green);

            //If there is a collision, send a message to the Interact object along with the collision object

            if(animator.GetInteger("walkDir") == 3)
                if(hit)
                    GameObject.FindGameObjectWithTag("InteractChat").SendMessage("MISC", hit.transform.tag);

            if (animator.GetInteger("walkDir") == 1)
                if (hit2)
                    GameObject.FindGameObjectWithTag("InteractChat").SendMessage("MISC", hit2.transform.tag);

            if (animator.GetInteger("walkDir") == 2 && (transform.localScale == new Vector3(1,1,1)))
                if (hit4)
                    GameObject.FindGameObjectWithTag("InteractChat").SendMessage("MISC", hit4.transform.tag);

            if (animator.GetInteger("walkDir") == 2 && (transform.localScale == new Vector3(-1, 1, 1)))
                if (hit3)
                    GameObject.FindGameObjectWithTag("InteractChat").SendMessage("MISC", hit3.transform.tag);
            
            
        }

        
	}
}
