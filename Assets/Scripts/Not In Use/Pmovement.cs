using UnityEngine;
using System.Collections;

public class Pmovement : MonoBehaviour
{
    public Transform playerSightF;
    public Transform playerSightL;
    public Transform playerSightD;
    public Transform playerSightR;
	public bool forward = false;
	public bool backwards = false;
	public bool left = false;
	public bool right = false;
    float distance = 1.0f;
    public LayerMask LCObj;
	public static bool interact = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

				Vector3 playerPosition = new Vector3 (0, 0, 0);


				//If the player moves foward he also sets his state for forward to calculate the raycast

				if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
						playerPosition = new Vector3 (0, 3) * Time.deltaTime;
						forward = true;
						backwards = false;
						left = false;
						right = false;
			transform.Translate(playerPosition);
				}
				//If the player moves down he also sets his state for backwards to calculate the raycast
				if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
						playerPosition = new Vector3 (0, -3) * Time.deltaTime;
						forward = false;
						backwards = true;
						left = false;
						right = false;
			transform.Translate(playerPosition);

				}

				//If the player moves left he also sets his state for left to calculate the raycast
		
				if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
						playerPosition = new Vector3 (-3, 0) * Time.deltaTime;

						forward = false;
						backwards = false;
						left = true;
						right = false;
			transform.Translate(playerPosition);

				}
				//if the player moves right set his state to the right
				if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
						playerPosition = new Vector3 (3, 0) * Time.deltaTime;

						forward = false;
						backwards = false;
						left = false;
						right = true;

			transform.Translate(playerPosition);
				}


		//if facing forward the line is drawn in front of the player

				if (forward == true) 
		        {
			if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
			{

                RaycastHit2D hit = Physics2D.Raycast(playerSightF.position, Vector2.up, distance, LCObj);
                if (hit.collider != null)
                {
                    Debug.Log("OBJ: " + hit.transform.name);
                    interact = true;
                }
                				
			}
				}

		if (right == true) {
						if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.Space)) {

                            RaycastHit2D hit = Physics2D.Raycast(playerSightR.position, Vector2.right, distance, LCObj);
                            if (hit.collider != null)
                            {
                                Debug.Log("OBJ: " + hit.transform.name);
                                interact = true;
                            }
                           
						}
				}

		if (backwards == true) 
		{
			if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
			{

                RaycastHit2D hit = Physics2D.Raycast(playerSightD.position, -Vector2.up, distance, LCObj);
                if (hit.collider != null)
                {
                    Debug.Log("OBJ: " + hit.transform.name);
                    interact = true;
                }
              
			}
		}

		if (left == true) 
		{
			if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
			{

                RaycastHit2D hit = Physics2D.Raycast(playerSightL.position, -Vector2.right, distance, LCObj);
                if (hit.collider != null)
                {
                    Debug.Log("OBJ: " + hit.transform.name);
                    interact = true;
                }
               
			}

		  }
        if (Input.GetKeyUp("e") || Input.GetKeyUp("space"))
        {
            interact = false;
        }
        }
      }
