using UnityEngine;
using System.Collections;

public class DontKillMe : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
}
