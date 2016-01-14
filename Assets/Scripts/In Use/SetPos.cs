using UnityEngine;
using System.Collections;

public class SetPos : MonoBehaviour {

    //       ( \_/ )
    //      =( ^.^ )=
    //      (") _ (")
    // Code By Adam O'Connor

    GameObject leaveFromUni, leaveFromClass, leaveFromCafe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        leaveFromUni = GameObject.FindWithTag("fromUniPos");
        leaveFromCafe = GameObject.FindWithTag("fromCafePos");
        leaveFromClass = GameObject.FindWithTag("fromClassPos");

        if(Exit_Door.fromUni == true)
        {
            transform.position = leaveFromUni.transform.position;
            Exit_Door.fromUni = false;
        }

        if (Uni_Door.fromCafe == true)
        {
            transform.position = leaveFromCafe.transform.position;
            Uni_Door.fromCafe = false;
        }

        if (GoToUni.fromClass == true)
        {
            transform.position = leaveFromClass.transform.position;
            GoToUni.fromClass = false;
        }
	
	}
}
