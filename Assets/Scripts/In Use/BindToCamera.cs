using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BindToCamera : MonoBehaviour {
    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    Canvas canvas;

	void Start () {
        canvas = GetComponent<Canvas>();
	}
	
	void Update () {
        //GetComponent<Canvas>().camera.renderer = Camera.main;
	}
}
