using UnityEngine;
using System.Collections;

public class CleanPixels : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

	void Start () {
        Camera.main.orthographicSize = Screen.height / 2f;
	}
	
	void Update () {
	
	}
}
