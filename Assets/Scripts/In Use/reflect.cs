using UnityEngine;
using System.Collections;

public class reflect : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    GameObject Reflection;
	// Use this for initialization
	void Start () {

	}

    void Update()
    {
    }
	// Update is called once per frame
	void Flip () {

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
	}
}
