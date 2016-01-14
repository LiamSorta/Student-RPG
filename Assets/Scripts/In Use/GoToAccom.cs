using UnityEngine;
using System.Collections;

public class GoToAccom : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Application.LoadLevel("Hall");
        }
    }
}
