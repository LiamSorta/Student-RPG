using UnityEngine;
using System.Collections;

public class car1Move : MonoBehaviour {

    //       ( \_/ )
    //      =( ^.^ )=
    //      (") _ (")
    // Code By Adam O'Connor

    public static bool Go1 = true;
    private bool nRigidbody = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(car1Move.Go1);
        if (Go1 == true)
        {
            if (nRigidbody == true)
            {                
                Rigidbody2D Addrigidbody = gameObject.AddComponent<Rigidbody2D>();
                Addrigidbody.fixedAngle = true;
                Addrigidbody.gravityScale = 0;
                nRigidbody = false;
            }
            gameObject.rigidbody2D.AddForce(Vector3.right * 750, 0);
        }
        if (Go1 == false)
        {
            Destroy(gameObject.rigidbody2D);
            nRigidbody = true;
        }
      
	}

}
