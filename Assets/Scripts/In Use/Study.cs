using UnityEngine;
using System.Collections;

public class Study : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    Color blackout;
	void Start () {
        blackout = Color.black;
        GetComponent<SpriteRenderer>().color = blackout;
    }
	
	void Update () {
        
        blackout.a -= 0.1f;
	}
}
