using UnityEngine;
using System.Collections;

public class GoToUni : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    public static bool fromClass = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (Application.loadedLevelName == "Classroom")
        {
            if (other.tag == "Player")
            {
                Application.LoadLevel("Uni");
                fromClass = true;
            }
        }

        if(Application.loadedLevelName == "Street")
        {
            if (other.tag == "Player")
            {
                Application.LoadLevel("Uni");
            }
        }
    }
}

