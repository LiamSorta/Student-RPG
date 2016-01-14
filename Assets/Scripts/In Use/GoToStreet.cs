using UnityEngine;
using System.Collections;

public class GoToStreet : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    public static bool fromAccom = false;
	// Use this for initialization
	void Start () {
	
	}
   
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {

        if (other.tag == "Player")
        {
            fromAccom = true;
            Application.LoadLevel("Street");
        }
	}
}
