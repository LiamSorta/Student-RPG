using UnityEngine;
using System.Collections;

public class Classroom : MonoBehaviour {
	
//Jamie Cox
    public static bool enterClass = false;
	void OnTriggerEnter2D(Collider2D coll)
	{
        if (coll.tag == "Player")
        {
            enterClass = true;
            Application.LoadLevel("Classroom");
        }
	}
	
}
