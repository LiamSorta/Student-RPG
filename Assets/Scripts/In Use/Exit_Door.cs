using UnityEngine;
using System.Collections;

public class Exit_Door : MonoBehaviour {

    //
    // Script by
    // Josh Bannister
    //
    public static bool fromUni = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            fromUni = true;
            Application.LoadLevel("Street");
        }
    }
}
