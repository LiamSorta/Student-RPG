using UnityEngine;
using System.Collections;

public class Uni_Door : MonoBehaviour {

    //
    // Script by
    // Josh Bannister
    //

	// Use this for initialization
    public static bool fromCafe = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("Uni");
            fromCafe = true;
        }
    }
}
