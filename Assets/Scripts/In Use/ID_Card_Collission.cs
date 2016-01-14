using UnityEngine;
using System.Collections;

public class ID_Card_Collission : MonoBehaviour {

    //
    // Script by
    // Josh Bannister
    //

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ID_Card")
        {
            print("ID Card collected!");
            Buggie_UI.has_ID_Card = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Door")
        {
            print("Door Touched");

        }
    }

}
